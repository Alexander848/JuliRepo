
namespace SnakeGame
{
    public partial class MainMenu : Form
    {
        Settings settings;
        DifficultyForm difficultyForm;

        public MainMenu()
        {
            InitializeComponent();
            settings = new Settings();
            difficultyForm = new DifficultyForm(this);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            difficultyForm = new DifficultyForm(this);
            difficultyForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings.FormClosed += delegate { Application.Exit(); };
            settings.ShowDialog();
            this.Show();
            
        }
    }
}
