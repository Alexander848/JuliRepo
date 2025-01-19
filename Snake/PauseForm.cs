
namespace SnakeGame
{
    public partial class PauseForm : Form
    {
        MainMenu mainMenu;
        Game game;
        GUIData guiData = new GUIData();

        public PauseForm(MainMenu mainMenu, Game game)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
            this.game = game;            
        }

        private void PauseForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            game.timer.Start();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            game.Hide();
            this.Close();
        }
    }
}
