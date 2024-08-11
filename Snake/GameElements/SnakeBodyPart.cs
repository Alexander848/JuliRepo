using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GameElements
{
    internal class SnakeBodyPart : GameElement
    {

        public SnakeBodyPart(int xPosition, int yPosition) : base(xPosition, yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }
    }
}
