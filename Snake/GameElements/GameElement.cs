using SnakeGame.GameElements.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GameElements
{
    internal class GameElement
    {
        public Position position { get; set; }

        public GameElement(Position position)
        {
            this.position = position;
        }
    }
}
