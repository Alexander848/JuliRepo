
namespace SnakeGame
{
    public partial class MainMenu : Form
    {
        DifficultyForm difficultyForm;
        SettingsForm settingsForm;
        private GUIData guiData = new GUIData();

        public MainMenu()
        {
            InitializeComponent();
            difficultyForm = new DifficultyForm(this);
            difficultyForm.FormClosing += delegate { Application.Exit(); };
            settingsForm = new SettingsForm(this);
            settingsForm.FormClosing += delegate { Application.Exit(); };
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            difficultyForm.Show();
            this.Hide();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
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
                this.ClientSize = GUIData.WindowSize;
                this.CenterToScreen();
            }

            SetButtonLayout();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            settingsForm.Show();
            this.Hide();
        }

        private void btn_exit_game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetButtonLayout()
        {
            btnStartGame.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            btnStartGame.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnStartGame.Font = new Font(btnExitGame.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnSettings.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 14 / 40);
            btnSettings.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnSettings.Font = new Font(btnExitGame.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnExitGame.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 27 / 40);
            btnExitGame.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnExitGame.Font = new Font(btnExitGame.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);
        }
    }
}
