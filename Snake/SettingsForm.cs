using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SettingsForm : Form
    {
        MainMenu mainMenu;
        GUIData guiData;

        public SettingsForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.guiData = new GUIData();
            this.mainMenu = mainMenu;
            cBoxScreenSize.Text = GUIData.WindowSize.Width + " x " + GUIData.WindowSize.Height;
        }

        private void SettingsForm_Activate(object sender, EventArgs e)
        {
            this.ClientSize = new Size(GUIData.WindowSize.Width, GUIData.WindowSize.Height);
            this.CenterToScreen();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();

            // If changes have not been saved, resets changes
            this.cBoxScreenSize.Text = GUIData.WindowSize.Width + " x " + GUIData.WindowSize.Height;
        }

        // Executes changes done in the settings
        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedResolutionString = (string)cBoxScreenSize.SelectedItem!;
            string[] splitResolutionString = selectedResolutionString.Split(' ');

            GUIData.WindowSize = new Size(Int32.Parse(splitResolutionString[0]), Int32.Parse(splitResolutionString[2]));
        }
    }
}
