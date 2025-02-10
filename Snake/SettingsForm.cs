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
            // Set Windowsize
            if (GUIData.FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.ClientSize = GUIData.WindowSize;
                this.CenterToScreen();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            // If changes have not been saved, resets changes
            this.cBoxScreenSize.Text = GUIData.WindowSize.Width + " x " + GUIData.WindowSize.Height;
            if (GUIData.FullScreen)
            {
                radioFullscreen.Checked = true;
                radioWindowed.Checked = false;
            } else {
                radioFullscreen.Checked = false; 
                radioWindowed.Checked = true;
            }
            // Reset fullscreen (whilst hidden)
            this.WindowState = FormWindowState.Normal;

            mainMenu.Show();
            this.Hide();
        }

        // Executes changes done in the settings
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioFullscreen.Checked)
            {
                GUIData.FullScreen = true;
            } else
            {
                GUIData.FullScreen = false;
                string selectedResolutionString = (string)cBoxScreenSize.SelectedItem!;
                string[] splitResolutionString = selectedResolutionString.Split(' ');

                GUIData.WindowSize = new Size(Int32.Parse(splitResolutionString[0]), Int32.Parse(splitResolutionString[2]));
            }

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
    }
}
