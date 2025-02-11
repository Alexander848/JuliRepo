
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

        private void PauseForm_Activated(object sender, EventArgs e)
        {
            SetButtonLayout();
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

        private void SetButtonLayout()
        {
            lblGamePaused.Location = new Point(guiData.GetPauseFormFrameWidth() / 40, guiData.GetPauseFormFrameHeight() / 40);
            lblGamePaused.Size = new Size(guiData.GetPauseFormFrameWidth() - (guiData.GetPauseFormFrameWidth() / 20), guiData.GetPauseFormFrameHeight() * 12 / 40);
            lblGamePaused.Font = new Font(lblGamePaused.Font.FontFamily, guiData.GetPauseFormFrameHeight() / 18, FontStyle.Bold);

            btnContinue.Location = new Point(guiData.GetPauseFormFrameWidth() / 40, guiData.GetPauseFormFrameHeight() * 14 / 40);
            btnContinue.Size = new Size(guiData.GetPauseFormFrameWidth() - (guiData.GetPauseFormFrameWidth() / 20), guiData.GetPauseFormFrameHeight() * 12 / 40);
            btnContinue.Font = new Font(btnContinue.Font.FontFamily, guiData.GetPauseFormFrameHeight() / 27, FontStyle.Bold);

            btnMainMenu.Location = new Point(guiData.GetPauseFormFrameWidth() / 40, guiData.GetPauseFormFrameHeight() * 27 / 40);
            btnMainMenu.Size = new Size(guiData.GetPauseFormFrameWidth() - (guiData.GetPauseFormFrameWidth() / 20), guiData.GetPauseFormFrameHeight() * 12 / 40);
            btnMainMenu.Font = new Font(btnMainMenu.Font.FontFamily, guiData.GetPauseFormFrameHeight() / 27, FontStyle.Bold);
        }
    }
}
