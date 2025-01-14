using SnakeGame.GameElements.Utilities;
using SnakeGame.GameElements;
using System.CodeDom;

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

// CONTINUE: Wie die ganzen Fenster geschlossen werden oder in Hintergrund gehen
// https://stackoverflow.com/questions/2683679/how-to-know-user-has-clicked-x-or-the-close-button
// fürn x Close


namespace SnakeGame
{
    public partial class Game : Form {

        private GUIData guiData = new GUIData();

        private PauseForm pauseForm;
        private GameOverForm gameOverForm;
        private MainMenu mainMenu;

        private Graphics graphics;
        private SolidBrush blueBrush;
        private SolidBrush greyBrush;
        private SolidBrush redBrush;
        private SolidBrush whiteBrush;  
        
        private Snake snake;
        private Board board;
        private Difficulty difficulty = Difficulty.Easy;
        private int score;

        public System.Windows.Forms.Timer timer { get; }

        public Game(MainMenu mainMenu, Difficulty difficulty)
        {
            InitializeComponent();

            ClientSize = new Size(guiData.GetGameFrameWidth(), guiData.GetGameFrameHeight() + guiData.GetGameFrameInterfaceHeight());

            graphics = this.CreateGraphics();
            blueBrush = new SolidBrush(Color.Blue);
            greyBrush = new SolidBrush(Color.Gray);
            redBrush = new SolidBrush(Color.Red);
            whiteBrush = new SolidBrush(Color.White);

            board = new Board();
            snake = new Snake();

            timer = new System.Windows.Forms.Timer();
            this.difficulty = difficulty;
            score = 0;

            this.mainMenu = mainMenu;
            pauseForm = new PauseForm(mainMenu, this);
            gameOverForm = new GameOverForm(mainMenu, this);
        }

        // Setup Game refresh interval and paint initial board(without snake)
        private void Game_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            timer.Tick += new EventHandler(TimerEventProcessor);

            if (difficulty == Difficulty.Hard)
            {
                timer.Interval = 60;
            }
            else if(difficulty == Difficulty.Medium)
            {
                timer.Interval = 90;
            } else
            {
                timer.Interval = 120;
            }
            
            timer.Start();
        }

        private void Game_Shown(object sender, EventArgs e) {
            PlaceAndDrawRocks();
            DrawSnakeAndAddToBoard();
            PlaceFood();
        }

        // Event that occurs every time the timer sets off an event
        private void TimerEventProcessor(Object? sender, EventArgs e)
        {
            MoveSnake();
            DetectSnakeHeadCollision();
            DrawSnakeAndAddToBoard();
        }

        //Moves the snake one step by adding an element in front and removing one in the back
        private void MoveSnake()
        {
            Position nextHeadPosition = snake.GetNextSnakeHeadPosition();
            if (nextHeadPosition != null)
            {
                snake.GetBody().AddFirst(new SnakeBodyPart(nextHeadPosition));
                snake.SetLastStepDirection(snake.GetMoveDirection());
            }
            if(snake.foodInStomach == 0)
            {
                SnakeBodyPart lastSnakeBodyPart = snake.GetBody().Last();
                graphics.FillRectangle(whiteBrush, lastSnakeBodyPart.position.x, lastSnakeBodyPart.position.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                snake.GetBody().RemoveLast();
            } else
            {
                // Snake recently ate food, that didnt yet get added to its lenght
                snake.foodInStomach--;
            } 
        }

        private void DetectSnakeHeadCollision()
        {
            Position snakeHeadPosition = snake.GetBody().First().position;
            int pixelToArrayPositionConversionX = guiData.GetStandartRectangleWidth();
            int pixelToArrayPositionConversionY = guiData.GetStandartRectangleHeight();
            GameElement collisionElement = board.boardElements[(int)snakeHeadPosition.x/pixelToArrayPositionConversionX][(int)snakeHeadPosition.y / pixelToArrayPositionConversionY];
            if (collisionElement != null)
            {
                if (collisionElement.GetType() == typeof(Rock)) {
                    EndGame();
                } else if (collisionElement.GetType() == typeof(Snake))
                {
                    //If it is the last snake element, it will be moved away from the area at the same time the snake head reaches it
                    SnakeBodyPart? snakeBodyPart = snake.GetBody().Last?.Value;
                    if (snakeBodyPart != null && collisionElement.position != snakeBodyPart.position)
                    {
                        EndGame();
                    }
                } else if (collisionElement.GetType() == typeof(Food))
                {
                    PlaceFood();
                    snake.foodInStomach++;
                    score++;
                    lblScoreValue.Text = score.ToString();
                }
            }
        }

        private void DrawSnakeAndAddToBoard()
        {
            if (snake != null)
            {
                foreach (SnakeBodyPart part in snake.GetBody())
                {
                    int standartRectangleWidth = guiData.GetStandartRectangleWidth();
                    int standartRectangleHeight = guiData.GetStandartRectangleHeight();

                    // Add Snake to Board
                    board.boardElements[part.position.x / standartRectangleWidth][part.position.y / standartRectangleHeight] = part;

                    //Draw Snake
                    graphics.FillRectangle(blueBrush, part.position.x, part.position.y, standartRectangleWidth, standartRectangleHeight);
                }
            }
        }

        private void PlaceFood()
        {
            GameElement[][] elements = board.boardElements;
            bool foodPlaced = false;
            Random rnd = new Random();

            Position nextSnakeHeadPosition = snake.GetNextSnakeHeadPosition();
            
            //Tries to randomly find an empty space on board to place fruit
            while (!foodPlaced)
            {
                int xCoordinate = rnd.Next(0, elements.Length);
                int yCoordinate = rnd.Next(0, elements[0].Length);

                if (elements[xCoordinate][yCoordinate].GetType() == typeof(EmptyArea) && new Position(xCoordinate, yCoordinate) != nextSnakeHeadPosition) 
                {
                    Position foodPosition = new Position(xCoordinate * guiData.GetStandartRectangleWidth(), yCoordinate * guiData.GetStandartRectangleHeight());
                    elements[xCoordinate][yCoordinate] = new Food(foodPosition);
                    graphics.FillRectangle(redBrush, foodPosition.x, foodPosition.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                    foodPlaced = true;
                }
            }
        }

        public void PlaceAndDrawRocks()
        {
            if (board.boardElements == null || board.boardElements.Length == 0)
            {
                return;
            }

            // Fill upper row with rocks
            for (int i = 0; i < board.boardElements.Length; i++)
            {
                if (board.boardElements[i][0].GetType() == typeof(EmptyArea))
                {
                    Position rockPosition = new Position(i * guiData.GetStandartRectangleWidth(), 0);
                    board.boardElements[i][0] = new Rock(rockPosition);
                    graphics.FillRectangle(greyBrush, rockPosition.x, rockPosition.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                }
            }

            //fill lower rock with rocks
            for (int i = 0; i < board.boardElements.Length; i++)
            {
                if (board.boardElements[i][board.boardElements[i].Length - 1].GetType() == typeof(EmptyArea))
                {
                    Position rockPosition = new Position(i * guiData.GetStandartRectangleWidth(), (board.boardElements[i].Length - 1) * guiData.GetStandartRectangleHeight());
                    board.boardElements[i][board.boardElements[i].Length - 1] = new Rock(rockPosition);
                    graphics.FillRectangle(greyBrush, rockPosition.x, rockPosition.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                }
            }

            //fill left side with rocks
            for (int i = 0; i < board.boardElements[0].Length; i++)
            {
                if (board.boardElements[0][i].GetType() == typeof(EmptyArea))
                {
                    Position rockPosition = new Position(0, i * guiData.GetStandartRectangleHeight());
                    board.boardElements[0][i] = new Rock(rockPosition);
                    graphics.FillRectangle(greyBrush, rockPosition.x, rockPosition.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                }
            }
            //fill right side with rocks
            for (int i = 0; i < board.boardElements[0].Length; i++)
            {
                if (board.boardElements[board.boardElements.Length - 1][i].GetType() == typeof(EmptyArea))
                {
                    Position rockPosition = new Position((board.boardElements.Length - 1) * guiData.GetStandartRectangleWidth(),i * guiData.GetStandartRectangleHeight());
                    board.boardElements[board.boardElements.Length - 1][i] = new Rock(rockPosition);
                    graphics.FillRectangle(greyBrush, rockPosition.x, rockPosition.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                }
            }
        }

        // Handles KeyPressed Events: Sets snake direction
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //Snake Movement
            if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && snake.GetLastStepDirection() != Direction.top)
            {
                snake.SetMoveDirection(Direction.bottom);
            }
            else if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && snake.GetLastStepDirection() != Direction.right)
            {
                snake.SetMoveDirection(Direction.left);
            }
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && snake.GetLastStepDirection() != Direction.bottom)
            {
                snake.SetMoveDirection(Direction.top);
            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && snake.GetLastStepDirection() != Direction.left)
            {
                snake.SetMoveDirection(Direction.right);
            }
            //Game Pause
            else if(e.KeyCode == Keys.Escape || e.KeyCode == Keys.Pause)
            {
                timer.Stop();
                pauseForm = new PauseForm(mainMenu, this);
                pauseForm.Show();
            }
        }

        private void EndGame()
        {
            timer.Stop();
            this.Hide();
            gameOverForm = new GameOverForm(mainMenu, this);
            gameOverForm.FormClosed += delegate { Application.Exit(); };
            gameOverForm.Show();
        }
    }
}
