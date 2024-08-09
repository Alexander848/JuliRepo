using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        private int length;
        private List<SnakeBodyPart> bodyParts;

        public Snake(int length, List<(int, int)> positions)
        {
            this.length = 2;
            bodyParts = new List<SnakeBodyPart>();
        }
    }
}
