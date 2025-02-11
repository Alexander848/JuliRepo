

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

            SetButtonLayout();
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

        private void SetButtonLayout()
        {
            lblSelectDiff.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            lblSelectDiff.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 9 / 40);
            lblSelectDiff.Font = new Font(lblSelectDiff.Font.FontFamily, GUIData.WindowSize.Height / 18, FontStyle.Bold);

            btnDiffEasy.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 22 / 80);
            btnDiffEasy.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnDiffEasy.Font = new Font(btnDiffEasy.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnDiffMedium.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 36 / 80);
            btnDiffMedium.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnDiffMedium.Font = new Font(btnDiffMedium.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnDiffHard.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 50 / 80);
            btnDiffHard.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnDiffHard.Font = new Font(btnDiffHard.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnBack.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 64 / 80);
            btnBack.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 6 / 40);
            btnBack.Font = new Font(btnBack.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
        }
    }
}
