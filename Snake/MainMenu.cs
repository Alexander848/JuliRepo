
namespace SnakeGame
{
    public partial class MainMenu : Form
    {
        DifficultyForm difficultyForm;

        public MainMenu()
        {
            InitializeComponent();
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
    }
}
