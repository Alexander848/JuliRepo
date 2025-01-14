

namespace SnakeGame
{
    public partial class DifficultyForm : Form
    {
        private GUIData guiData = new GUIData();
        Game? game;
        MainMenu mainMenu;

        public DifficultyForm(MainMenu mainMenu)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
        }

        private void DifficultyForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnDiffEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            game = new Game(mainMenu, Difficulty.Easy);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
        }

        private void btnDiffMedium_Click(object sender, EventArgs e)
        {
            this.Hide();
            game = new Game(mainMenu, Difficulty.Medium);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
        }

        private void btnDiffHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            game = new Game(mainMenu, Difficulty.Hard);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
