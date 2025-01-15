using SnakeGame.GameElements.Utilities;

namespace SnakeGame
{
    internal class GUIData
    {
        // Game Graphic Element Sizes
        private readonly int gameFrameWidth = 800;
        private readonly int gameFrameHeight = 460;
        private readonly int gameFrameInterfaceHeight = 100;

        private readonly int difficultyFrameWidth = 260;
        private readonly int difficultyFrameHeight = 240;

        private readonly int pauseFormFrameWidth = 480;
        private readonly int pauseFormFrameHeight = 280;
        
        private readonly int standartRectangleHeight = 20;
        private readonly int standartRectangleWidth = 20;

        private readonly Position snakeStartPositionHead = new Position(5, 5);
        private readonly Position snakeStartPositionTail = new Position(4, 5);

        // Brushes
        private readonly SolidBrush _blueBrush = new SolidBrush(Color.Blue);
        public SolidBrush BlueBrush { get { return _blueBrush; } }
        private readonly SolidBrush _greyBrush = new SolidBrush(Color.Gray);
        public SolidBrush GreyBrush { get { return _greyBrush; } }
        private readonly SolidBrush _redBrush = new SolidBrush(Color.Red);
        public SolidBrush RedBrush { get { return _redBrush; } }
        private readonly SolidBrush _whiteBrush = new SolidBrush(Color.White);
        public SolidBrush WhiteBrush { get { return _whiteBrush; } }

        public int GetGameFrameHeight()
        {
            return gameFrameHeight;
        }
        public int GetGameFrameWidth()
        {
            return gameFrameWidth;
        }
        public int GetGameFrameInterfaceHeight()
        {
            return gameFrameInterfaceHeight;
        }
        public int GetDifficultyFrameHeight()
        {
            return difficultyFrameHeight;
        }
        public int GetDifficultyFrameWidth()
        {
            return difficultyFrameWidth;
        }
        public int GetPauseFormFrameHeight()
        {
            return pauseFormFrameHeight;
        }
        public int GetPauseFormFrameWidth()
        {
            return pauseFormFrameWidth;
        }
        public int GetStandartRectangleHeight()
        {
            return standartRectangleHeight;
        }
        public int GetStandartRectangleWidth()
        {
            return standartRectangleWidth;
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
