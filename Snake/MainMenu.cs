using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class MainMenu : Form
    {
        Game game;

        public MainMenu()
        {
            InitializeComponent();
            game = new Game();
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
    }
}
