using SnakeGame.GameElements.Utilities;

namespace SnakeGame
{
    internal class GUIData
    {
        // Game Graphic Element Sizes
        private readonly int gameFrameWidth = 800;
        private readonly int gameFrameHeight = 460;
        
        private readonly int standartRectangleHeight = 20;
        private readonly int standartRectangleWidth = 20;

        private readonly Position snakeStartPositionHead = new Position(100, 100);
        private readonly Position snakeStartPositionTail = new Position(80, 100);


        public int GetStandartRectangleHeight()
        {
            return standartRectangleHeight;
        }
        public int GetStandartRectangleWidth()
        {
            return standartRectangleWidth;
        }
        public int GetGameFrameHeight()
        {
            return gameFrameHeight;
        }
        public int GetGameFrameWidth()
        {
            return gameFrameWidth;
        }
        public Position GetSnakeStartPositionHead()
        {
            return snakeStartPositionHead;
        }
        public Position GetSnakeStartPositionTail()
        {
            return snakeStartPositionTail;
        }
    }
}
