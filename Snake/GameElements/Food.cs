
using SnakeGame.GameElements.Utilities;

namespace SnakeGame.GameElements
{
    internal class Food : GameElement
    {
        public Food(Position position) : base(position)
        {
            this.position = position;
        }
    }
}
