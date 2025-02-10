
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
                this.ClientSize = new Size(GUIData.WindowSize.Width, GUIData.WindowSize.Height);
                this.CenterToScreen();
            }
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
    }
}
