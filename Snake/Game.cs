using SnakeGame.GameElements.Utilities;
using SnakeGame.GameElements;

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

namespace SnakeGame
{
    public partial class Game : Form { 

        private Graphics g;
        private SolidBrush snakeBrush;
        private SolidBrush rockBrush;
        private SolidBrush foodBrush;
        private GUIData guiData = new GUIData();
        private Snake snake;
        private Board board;
        private Difficulty difficulty = Difficulty.Easy;
        private PauseForm pauseForm;
        private MainMenu mainMenu;

        public System.Windows.Forms.Timer timer { get; }

        public Game(MainMenu mainMenu, Difficulty difficulty)
        {
            InitializeComponent();

            ClientSize = new Size(guiData.GetGameFrameWidth(), guiData.GetGameFrameHeight());

            g = this.CreateGraphics();
            snakeBrush = new SolidBrush(Color.Blue);
            rockBrush = new SolidBrush(Color.Gray);
            foodBrush = new SolidBrush(Color.Red);

            board = new Board();
            snake = new Snake();

            timer = new System.Windows.Forms.Timer();
            this.difficulty = difficulty;

            this.mainMenu = mainMenu;
            pauseForm = new PauseForm(mainMenu, this);
        }

        // Setup Game refresh interval and paint initial board(without snake)
        private void Game_Load(object sender, EventArgs e)
        {
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

            board.PlaceRocks();
            PlaceSnakeOnBoard();
            PlaceFood();
        }

        // Event that occurs every time the timer sets off an event
        private void TimerEventProcessor(Object? sender, EventArgs e)
        {
            UpdateSnakeMovement();
        }

        //Initially places snake on board
        private void PlaceSnakeOnBoard()
        {
            if (snake != null)
            {
                foreach (SnakeBodyPart part in snake.GetBody())
                {
                    board.boardElements[part.position.x / guiData.GetStandartRectangleWidth()][part.position.y / guiData.GetStandartRectangleHeight()] = part;
                }
            }
        }

        public void UpdateSnakeMovement()
        {
            CheckForCollision();

            PaintBoard();

            MoveSnakeBodyOneStep();

            foreach (SnakeBodyPart snakePart in snake.GetBody())
            {
                g.FillRectangle(snakeBrush, snakePart.position.x, snakePart.position.y, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
            }
        }

        // Clears the Board and repaints rocks
        private void PaintBoard()
        {
            g.Clear(Color.White);
            GameElement[][] boardElements = board.boardElements;

            for (int i = 0; i < boardElements.Length; i++)
            {
                for (int j = 0; j < boardElements[i].Length; j++)
                {
                    if (boardElements[i][j] != null && boardElements[i][j].GetType() == typeof(Rock))
                    {
                        g.FillRectangle(rockBrush, i* guiData.GetStandartRectangleWidth(), j* guiData.GetStandartRectangleHeight(),
                            guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                    } else if(boardElements[i][j] != null && boardElements[i][j].GetType() == typeof(Food))
                    {
                        g.FillRectangle(foodBrush, i * guiData.GetStandartRectangleWidth(), j * guiData.GetStandartRectangleHeight(),
                            guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
                    }
                }
            }
        }

        // TODO: Wenn Schlange an Fensterrand läuft, wird es vrrstl Fehler geben
        // Moves the whole snakebody one step forward and the first element in the direction the snake is moving next
        private void MoveSnakeBodyOneStep()
        {
            int previousBodyPartX = 0;
            int previousBodyPartY = 0;

            // Iterate SnakeBodyParts, move them all one forward and add to board
            foreach (SnakeBodyPart snakePart in snake.GetBody())
            {
                int xPositionPlaceholder = snakePart.position.x;
                int yPositionPlaceholder = snakePart.position.y;

                //Elements in the middle
                if (snakePart != snake.GetBody().First())
                {
                    snakePart.position.x = previousBodyPartX;
                    snakePart.position.y = previousBodyPartY;
                }
                //First element
                else
                {
                    Position nextPosition = snake.GetNextSnakeHeadPosition();

                    snakePart.position = nextPosition;

                    snake.SetLastStepDirection(snake.GetMoveDirection());
                    board.boardElements[snakePart.position.x / guiData.GetStandartRectangleWidth()][snakePart.position.y / guiData.GetStandartRectangleHeight()] = snakePart;
                }            

                previousBodyPartX = xPositionPlaceholder;
                previousBodyPartY = yPositionPlaceholder;
            }

            // remove last element from board if there is no food in stomach
            if (snake.foodInStomach == 0)
            {
                board.boardElements[previousBodyPartX / guiData.GetStandartRectangleWidth()][previousBodyPartY / guiData.GetStandartRectangleHeight()]
                                    = new EmptyArea(new Position(previousBodyPartX, previousBodyPartY));
            }
            else
            {
                // Snake becomes longer
                snake.foodInStomach--;
                snake.GetBody().AddLast(new SnakeBodyPart(new Position(previousBodyPartX, previousBodyPartY)));
            }
        }

        // Checks if snake will collide with any element(food, rock, snake) on its next step
        private void CheckForCollision()
        {
            Position nextPosition = snake.GetNextSnakeHeadPosition();

            GameElement collisionElement = board.boardElements[nextPosition.x / guiData.GetStandartRectangleWidth()][nextPosition.y / guiData.GetStandartRectangleHeight()];

            if (collisionElement != null)
            {
                if(collisionElement.GetType() == typeof(Rock) || collisionElement.GetType() == typeof(SnakeBodyPart))
                {
                    timer.Stop();
                } else if (collisionElement.GetType() == typeof(Food))
                {
                    PlaceFood();
                    snake.foodInStomach++;
                } 
            }
        }

        private void PlaceFood()
        {
            GameElement[][] elements = board.boardElements;
            bool foodPlaced = false;
            Random rnd = new Random();
            
            //Tries to randomly find an empty space on board to place fruit
            while (!foodPlaced)
            {
                int xCoordinate = rnd.Next(0, elements.Length);
                int yCoordinate = rnd.Next(0, elements[0].Length);

                if (elements[xCoordinate][yCoordinate].GetType() == typeof(EmptyArea))
                {
                    elements[xCoordinate][yCoordinate] = new Food(new Position(xCoordinate * guiData.GetStandartRectangleWidth(), yCoordinate * guiData.GetStandartRectangleHeight()));
                    foodPlaced = true;
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
                pauseForm.FormClosed += delegate { timer.Start(); };
                pauseForm.Show();
            }
        }
    }
}
