using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class SnakeBodyPart
    {
        private int x_position;
        private int y_position;

        public SnakeBodyPart(int x_position, int y_position)
        {
            this.x_position = x_position;
            this.y_position = y_position;
        }
    }
}
