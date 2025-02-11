
namespace SnakeGame
{
    public partial class GameOverForm : Form
    {
        GUIData guiData = new GUIData();
        MainMenu mainMenu;
        Game game;
        DifficultyForm difficultyForm;


        public GameOverForm(MainMenu mainMenu, Game game)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
            this.game = game;
            difficultyForm = new DifficultyForm(mainMenu);
        }

        private void GameOverForm_Activate(object sender, EventArgs e)
        {
            SetButtonLayout();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            difficultyForm = new DifficultyForm(mainMenu);
            difficultyForm.FormClosed += delegate { Application.Exit(); };
            difficultyForm.Show();
        }

        private void SetButtonLayout()
        {
            lblGameOver.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            lblGameOver.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            lblGameOver.Font = new Font(lblGameOver.Font.FontFamily, GUIData.WindowSize.Height / 18, FontStyle.Bold);

            btnNewGame.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 14 / 40);
            btnNewGame.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnNewGame.Font = new Font(btnNewGame.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnMainMenu.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 27 / 40);
            btnMainMenu.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnMainMenu.Font = new Font(btnMainMenu.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
        }
    }
}
