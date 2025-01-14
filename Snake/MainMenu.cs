
namespace SnakeGame
{
    public partial class MainMenu : Form
    {
        DifficultyForm difficultyForm;
        private GUIData guiData = new GUIData();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            difficultyForm = new DifficultyForm(this);
            difficultyForm.FormClosing += delegate { Application.Exit(); };
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
