using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Direction
{
    top, bottom, left, right
}

namespace Snake
{
    internal class Snake
    {
        private LinkedList<SnakeBodyPart> body;
        private Direction moveDirection;

        public Snake()
        {
            this.moveDirection = Direction.right;

            this.body = new LinkedList<SnakeBodyPart>();
            InitSnake();
        }

        // Setzt Snake Body Parts an initiale Position
        private void InitSnake()
        {
            body.AddFirst(new SnakeBodyPart(50, 50));
            body.AddFirst(new SnakeBodyPart(60, 50));
        }

        //Getter und Setter
        public LinkedList<SnakeBodyPart> GetBody()
        {
            return this.body;
        }
        public void SetBodyPart(LinkedList<SnakeBodyPart> bodyPart)
        {
            this.body = bodyPart;
        }
        public Direction GetMoveDirection()
        {
            return this.moveDirection;
        }
        public void SetMoveDirection(Direction moveDirection)
        {
            this.moveDirection = moveDirection;
        }
    }
}
