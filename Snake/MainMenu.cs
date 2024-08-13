
namespace SnakeGame
{
    public partial class MainMenu : Form
    {
        Game game;
        Settings settings;

        public MainMenu()
        {
            InitializeComponent();
            game = new Game();
            settings = new Settings();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings = new Settings();
            settings.FormClosing += delegate { Application.Exit(); };
            settings.Show();
            this.Hide();
        }
    }
}
