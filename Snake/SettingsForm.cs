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
            SetWindowSize();
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
                GUIData.WindowSize = new Size(Screen.FromControl(this).Bounds.Width, Screen.FromControl(this).Bounds.Height);
            } else
            {
                GUIData.FullScreen = false;
                string selectedResolutionString = (string)cBoxScreenSize.SelectedItem!;
                string[] splitResolutionString = selectedResolutionString.Split(' ');

                GUIData.WindowSize = new Size(Int32.Parse(splitResolutionString[0]), Int32.Parse(splitResolutionString[2]));
            }

            SetWindowSize();

            SetButtonSizes();
        }

        private void SetWindowSize()
        {
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

        private void SetButtonSizes()
        {
            cBoxScreenSize.Location = new Point(GUIData.WindowSize.Width * 21 / 80, GUIData.WindowSize.Height * 3 / 80);
            cBoxScreenSize.Size = new Size(GUIData.WindowSize.Width * 17 / 80, GUIData.WindowSize.Height * 5 / 40);
            cBoxScreenSize.Font = new Font(cBoxScreenSize.Font.FontFamily, GUIData.WindowSize.Height / 24, FontStyle.Bold);

            btnBack.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 14 / 40);
            btnBack.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnBack.Font = new Font(btnBack.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            btnSave.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height * 27 / 40);
            btnSave.Size = new Size(GUIData.WindowSize.Width - (GUIData.WindowSize.Width / 20), GUIData.WindowSize.Height * 12 / 40);
            btnSave.Font = new Font(btnSave.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            radioWindowed.Location = new Point(GUIData.WindowSize.Width / 80, GUIData.WindowSize.Height / 80);
            radioWindowed.Size = new Size(GUIData.WindowSize.Width * 17 / 80, GUIData.WindowSize.Height * 5 / 40);
            radioWindowed.Font = new Font(radioWindowed.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            radioFullscreen.Location = new Point(GUIData.WindowSize.Width / 80, GUIData.WindowSize.Height * 6 / 40);
            radioFullscreen.Size = new Size(GUIData.WindowSize.Width * 17 / 80, GUIData.WindowSize.Height * 5 / 40);
            radioFullscreen.Font = new Font(radioFullscreen.Font.FontFamily, GUIData.WindowSize.Height / 27, FontStyle.Bold);

            groupBoxWindow.Location = new Point(GUIData.WindowSize.Width / 40, GUIData.WindowSize.Height / 40);
            groupBoxWindow.Size = new Size(GUIData.WindowSize.Width * 9 / 40, GUIData.WindowSize.Height * 12 / 40);
        }
    }
}
