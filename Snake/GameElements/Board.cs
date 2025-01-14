using SnakeGame.GameElements.Utilities;

namespace SnakeGame.GameElements
{
    internal class Board
    {
        public GameElement[][] boardElements { get; set; }
        private GUIData guiData = new GUIData();

        public Board()
        {
            boardElements = new GameElement[guiData.GetGameFrameWidth()/guiData.GetStandartRectangleWidth()][];
            for (int i = 0; i < boardElements.Length; i++)
            {
                boardElements[i] = new GameElement[guiData.GetGameFrameHeight() / guiData.GetStandartRectangleHeight()];

                for (int j = 0; j < boardElements[i].Length; j++)
                {
                    boardElements[i][j] = new EmptyArea(new Position(i*guiData.GetStandartRectangleWidth(), j*guiData.GetStandartRectangleHeight()));
                }
            }
        }
    }
}
