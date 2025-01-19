using SnakeGame.GameElements.Utilities;
using SnakeGame.GameElements;
using System.CodeDom;

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}


namespace SnakeGame
{
    public partial class Game : Form {

        private GUIData guiData = new GUIData();

        private PauseForm pauseForm;
        private GameOverForm gameOverForm;
        private MainMenu mainMenu;

        private Graphics graphics; 
        
        private Snake snake;
        private Board board;
        private Difficulty difficulty = Difficulty.Easy;
        private int score;

        public System.Windows.Forms.Timer timer { get; }

        public Game(MainMenu mainMenu, Difficulty difficulty)
        {
            InitializeComponent();

            ClientSize = new Size(guiData.GameFrameSize.Width, guiData.GameFrameSize.Height + guiData.GameFrameInterfaceHeight);

            graphics = this.CreateGraphics();

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
                timer.Interval = 40;
            }
            else if(difficulty == Difficulty.Medium)
            {
                timer.Interval = 80;
            } else
            {
                timer.Interval = 120;
            }
            
            timer.Start();
        }

        private void Game_Shown(object sender, EventArgs e) {
            board.PlaceRocks();
            board.PlaceSnake();
            board.PlaceFood(snake);
            board.DrawBoard(graphics);
        }

        // Event that occurs every time the timer sets off an event
        private void TimerEventProcessor(Object? sender, EventArgs e)
        {
            bool gameGood = board.MoveSnakeAndDetectCollision(ref this.score, ref snake);
            if (!gameGood)
            {
                EndGame();
            }
            board.DrawBoard(graphics);
            lblScoreValue.Text = score.ToString();
        }        

        // Handles KeyPressed Events: Sets snake direction
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //Snake Movement
            if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && snake.LastStepDirection != Direction.top)
            {
                snake.MoveDirection = Direction.bottom;
            }
            else if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && snake.LastStepDirection != Direction.right)
            {
                snake.MoveDirection = Direction.left;
            }
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && snake.LastStepDirection != Direction.bottom)
            {
                snake.MoveDirection = Direction.top;
            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && snake.LastStepDirection != Direction.left)
            {
                snake.MoveDirection = Direction.right;
            }
            //Game Pause
            else if(e.KeyCode == Keys.Escape || e.KeyCode == Keys.Pause)
            {
                PauseGame();
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

        private void PauseGame()
        {
            timer.Stop();
            pauseForm = new PauseForm(mainMenu, this);
            pauseForm.ShowInTaskbar = false;
            pauseForm.Show(this);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }
    }
}
