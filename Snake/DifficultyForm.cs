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
    public partial class DifficultyForm : Form
    {
        GUIData guiData;
        Game game;
        MainMenu mainMenu;

        public DifficultyForm(MainMenu mainMenu)
        {
            InitializeComponent();

            guiData = new GUIData();
            this.mainMenu = mainMenu;
            game = new Game(mainMenu, Difficulty.Easy);
        }

        private void btnDiffEasy_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            this.Close();
            game = new Game(mainMenu, Difficulty.Easy);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
            
        }

        private void btnDiffMedium_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            this.Close();
            game = new Game(mainMenu, Difficulty.Medium);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
        }

        private void btnDiffHard_Click(object sender, EventArgs e)
        {
            mainMenu.Hide();
            this.Close();
            game = new Game(mainMenu, Difficulty.Hard);
            game.FormClosing += delegate { Application.Exit(); };
            game.Show();
        }
    }
}
