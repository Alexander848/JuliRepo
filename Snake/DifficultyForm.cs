

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

        private void DifficultyForm_Activated(object sender, EventArgs e)
        {
            // Set Windowsize
            if (GUIData.FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.ClientSize = new Size(GUIData.WindowSize.Width, GUIData.WindowSize.Height);
                this.CenterToScreen();
            }
        }

        private void btnDiffEasy_Click(object sender, EventArgs e)
        {
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            game = new Game(mainMenu, Difficulty.Easy);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
            this.Hide();
        }

        private void btnDiffMedium_Click(object sender, EventArgs e)
        {
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            game = new Game(mainMenu, Difficulty.Medium);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
            this.Hide();
        }

        private void btnDiffHard_Click(object sender, EventArgs e)
        {
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            game = new Game(mainMenu, Difficulty.Hard);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            mainMenu.Show();
            this.Hide();
        }
    }
}
