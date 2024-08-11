

using Microsoft.VisualBasic;
using SnakeGame.GameElements;

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

        int testIterator = 0;

        private System.Windows.Forms.Timer timer;

        public Game()
        {
            InitializeComponent();

            ClientSize = new Size(guiData.GetGameFrameWidth(), guiData.GetGameFrameHeight());

            g = this.CreateGraphics();
            snakeBrush = new SolidBrush(Color.Blue);
            rockBrush = new SolidBrush(Color.Gray);
            foodBrush = new SolidBrush(Color.Red);

            board = new Board();
            snake = new Snake();
            PlaceSnakeOnBoard();

            timer = new System.Windows.Forms.Timer();
        }

        // Setup Game refresh interval and paint initial board(without snake)
        private void Game_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 100;
            timer.Start();

            board.FillBoard();
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
                    board.boardElements[part.xPosition / guiData.GetStandartRectangleWidth()][part.yPosition / guiData.GetStandartRectangleHeight()] = part;
                }
            }
        }

        public void UpdateSnakeMovement()
        {
            testIterator++;

            if(testIterator == 5)
            {
                PlaceFood();
                testIterator = 0;
            }

            PaintBoard();

            MoveSnakeBodyOneStep();

            CheckForCollision();

            foreach (SnakeBodyPart snakePart in snake.GetBody())
            {
                g.FillRectangle(snakeBrush, snakePart.xPosition, snakePart.yPosition, guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
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
                int xPositionPlaceholder = snakePart.xPosition;
                int yPositionPlaceholder = snakePart.yPosition;

                //Elements in the middle
                if (snakePart != snake.GetBody().First())
                {
                    snakePart.xPosition = previousBodyPartX;
                    snakePart.yPosition = previousBodyPartY;
                }
                //First element
                else
                {
                    switch (snake.GetMoveDirection())
                    {
                        case Direction.top:
                            snakePart.yPosition = snakePart.yPosition - guiData.GetStandartRectangleHeight();
                            break;
                        case Direction.bottom:
                            snakePart.yPosition = snakePart.yPosition + guiData.GetStandartRectangleHeight();
                            break;
                        case Direction.left:
                            snakePart.xPosition = snakePart.xPosition - guiData.GetStandartRectangleWidth();
                            break;
                        default:
                            snakePart.xPosition = snakePart.xPosition + guiData.GetStandartRectangleWidth();
                            break;
                    }

                    snake.SetLastStepDirection(snake.GetMoveDirection());
                    board.boardElements[snakePart.xPosition / guiData.GetStandartRectangleWidth()][snakePart.yPosition / guiData.GetStandartRectangleHeight()] = snakePart;
                }

                // remove last element from board
                board.boardElements[previousBodyPartX / guiData.GetStandartRectangleWidth()][previousBodyPartY / guiData.GetStandartRectangleHeight()]
                    = new EmptyArea(previousBodyPartX, previousBodyPartY);

                previousBodyPartX = xPositionPlaceholder;
                previousBodyPartY = yPositionPlaceholder;
            }
        }

        private void CheckForCollision()
        {
            //TODO
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
                    elements[xCoordinate][yCoordinate] = new Food(xCoordinate * guiData.GetStandartRectangleWidth(), yCoordinate * guiData.GetStandartRectangleHeight());
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
        }
    }
}
