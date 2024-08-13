using SnakeGame.GameElements.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GameElements
{
    internal class EmptyArea : GameElement
    {

        public EmptyArea(Position position) : base(position) {
            this.position = position;
        }
    }
}
