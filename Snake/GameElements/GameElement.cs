using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GameElements
{
    internal class GameElement
    {
        public int xPosition{ get; set; }
        public int yPosition { get; set; }

        public GameElement(int xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }
    }
}
