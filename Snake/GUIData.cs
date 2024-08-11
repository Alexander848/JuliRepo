using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class GUIData
    {
        // Game Graphic Element Sizes
        private readonly int standartRectangleHeight = 10;
        private readonly int standartRectangleWidth = 10;

        private readonly int gameFrameWidth = 800;
        private readonly int gameFrameHeight = 450;


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
    }
}
