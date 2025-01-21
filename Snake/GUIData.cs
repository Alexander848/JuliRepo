using SnakeGame.GameElements.Utilities;

namespace SnakeGame
{
    internal class GUIData
    {
        // Window Size
        private static bool _fullScreen = false;
        public static bool FullScreen
        { 
            get { return _fullScreen; } 
            set { _fullScreen = value; }
        }

        private static Size _windowSize = new Size(1600, 920);
        public static Size WindowSize
        {
            get { return _windowSize; }
            set { _windowSize = value; }
        }

        // Game Graphic Element Sizes
        private Size _gameFrameSize = new Size(800, 460);
        public Size GameFrameSize
        {
            get { return _gameFrameSize; }
            set { _gameFrameSize = value; }
        }
        private int _gameFrameInterfaceHeight = 100;
        public int GameFrameInterfaceHeight
        {
            get { return _gameFrameInterfaceHeight; }
            set { _gameFrameInterfaceHeight = value; }
        }
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
