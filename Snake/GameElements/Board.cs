
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
                    boardElements[i][j] = new EmptyArea(i*guiData.GetStandartRectangleWidth(), j*guiData.GetStandartRectangleHeight());
                }
            }
        }

        public void FillBoard()
        {
            if (boardElements == null || boardElements.Length == 0)
            {
                return;
            }

            // Fill upper row with rocks
            for (int i = 0; i < boardElements.Length; i++)
            {
                if (boardElements[i][0].GetType() == typeof(EmptyArea))
                {
                    boardElements[i][0] = new Rock(i * guiData.GetStandartRectangleWidth(), 0);
                }
            }

            //fill lower rock with rocks
            for (int i = 0; i < boardElements.Length; i++)
            {
                if(boardElements[i][boardElements[i].Length-1].GetType() == typeof(EmptyArea))
                {
                    boardElements[i][boardElements[i].Length - 1] = new Rock(i * guiData.GetStandartRectangleWidth(),
                        (boardElements[i].Length - 1) * guiData.GetStandartRectangleHeight());
                }
            }

            //fill left side with rocks
            for(int i = 0; i < boardElements[0].Length; i++)
            {
                if (boardElements[0][i].GetType() == typeof(EmptyArea))
                {
                    boardElements[0][i] = new Rock(0, i* guiData.GetStandartRectangleHeight());
                }
            }
            //fill right side with rocks
            for(int i = 0; i < boardElements[0].Length; i++)
            {
                if (boardElements[boardElements.Length-1][i].GetType() == typeof(EmptyArea))
                {
                    boardElements[boardElements.Length - 1][i] = new Rock((boardElements.Length - 1) * guiData.GetStandartRectangleWidth(),
                        i * guiData.GetStandartRectangleHeight());
                }
            }
        }

    }
}
