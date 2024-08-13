
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
            game.Hide();
            this.Close();
            mainMenu.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.Hide();
            this.Close();
            difficultyForm = new DifficultyForm(mainMenu);
            difficultyForm.Show();
        }
    }
}
