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
        GUIData guiData = new GUIData();

        Snake snake;

        int tempFun = 0;

        public Game()
        {
            InitializeComponent();

            g = this.CreateGraphics();
            selPen = new Pen(Color.Blue);

            snake = new Snake();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }


        //CONTINUE Muss responsive während zeichnen sein
        public async Task StartGame()
        {
            int i = 0;
            while (true)
            {
                /*Task drawRectangleTask = DrawRectangle(i);
                await drawRectangleTask;*/

                Task drawSnake = UpdateSnakeMovement();
                await drawSnake;

                Thread.Sleep(100);
            }
            
        }

        public Task DrawRectangle(int i)
        {
            g.DrawRectangle(selPen, 10+5*i, 10+5*i, 50, 50);

            return Task.CompletedTask;
        }

        public Task UpdateSnakeMovement()
        {
            if (tempFun == 3)
            {
                if (snake.GetMoveDirection() == Direction.left)
                {
                    snake.SetMoveDirection(Direction.top);
                } else if (snake.GetMoveDirection() == Direction.top) {
                    snake.SetMoveDirection(Direction.right);
                } else if (snake.GetMoveDirection() == Direction.right){
                    snake.SetMoveDirection(Direction.bottom);
                } else if (snake.GetMoveDirection() == Direction.bottom) {
                    snake.SetMoveDirection(Direction.left);
                }

                tempFun = 0;
            } else
            {
                tempFun++;
            }

            g.Clear(Color.White);

            MoveSnakeBodyOneStep();

            foreach(SnakeBodyPart snakePart in snake.GetBody())
            {
                g.DrawRectangle(selPen, snakePart.GetXPosition(), snakePart.GetYPosition(), guiData.GetStandartRectangleWidth(), guiData.GetStandartRectangleHeight());
            }

            return Task.CompletedTask;
        }

        // TODO: Wenn Schlange an Fensterrand läuft, wird es vrrstl Fehler geben
        // Moves the whole snakebody one step forward and the first element in the direction the snake is moving next
        private void MoveSnakeBodyOneStep()
        {
            int previousBodyPartX = 0;
            int previousBodyPartY = 0;

            foreach (SnakeBodyPart snakePart in snake.GetBody())
            {
                int xPositionPlaceholder = snakePart.GetXPosition();
                int yPositionPlaceholder = snakePart.GetYPosition();

                if (snakePart != snake.GetBody().First())
                {
                    snakePart.SetXPosition(previousBodyPartX);
                    snakePart.SetYPosition(previousBodyPartY);
                } else
                {
                    switch (snake.GetMoveDirection())
                    {
                        case Direction.top:
                            snakePart.SetYPosition(snakePart.GetYPosition() - guiData.GetStandartRectangleHeight());
                            break;
                        case Direction.bottom:
                            snakePart.SetYPosition(snakePart.GetYPosition() + guiData.GetStandartRectangleHeight());
                            break;
                        case Direction.left:
                            snakePart.SetXPosition(snakePart.GetXPosition() - guiData.GetStandartRectangleWidth());
                            break;
                        default:
                            snakePart.SetXPosition(snakePart.GetXPosition() + guiData.GetStandartRectangleWidth());
                            break;
                    }
                }

                previousBodyPartX = xPositionPlaceholder;
                previousBodyPartY = yPositionPlaceholder;
            }
        }
    }
}
