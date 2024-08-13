
using SnakeGame.GameElements.Utilities;

namespace SnakeGame.GameElements
{
    internal class Rock : GameElement
    {
        public Rock(Position position) : base(position)
        {
            this.position = position;
        }
    }
}
