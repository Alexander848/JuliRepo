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
    public partial class Game : Form
    {

        Graphics g;
        Pen selPen;

        public Game()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            selPen = new Pen(Color.Blue);
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }


        //CONTINUE Muss responsive während zeichnen sein
        public async Task StartGame()
        {
            int i = 0;
            while (i < 20)
            {
                /*Task drawRectangleTask = DrawRectangle(i);
                await drawRectangleTask;*/

                Task drawSnake = DrawSnake();
                await drawSnake;

                Thread.Sleep(100);
                i++;
            }
            
        }

        public Task DrawRectangle(int i)
        {
            g.DrawRectangle(selPen, 10+5*i, 10+5*i, 50, 50);

            return Task.CompletedTask;
        }

        public Task DrawSnake()
        {
            g.DrawRectangle

            return Task.CompletedTask;
        }
    }
}
