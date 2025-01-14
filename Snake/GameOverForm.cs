
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

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

            private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.Show();
            game.Hide();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            difficultyForm = new DifficultyForm(mainMenu);
            difficultyForm.FormClosed += delegate { this.Close(); };
            difficultyForm.ShowDialog();
        }
    }
}
