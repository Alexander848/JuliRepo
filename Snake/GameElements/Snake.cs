using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Direction
{
    top, bottom, left, right
}

namespace SnakeGame.GameElements
{
    internal class Snake
    {
        private LinkedList<SnakeBodyPart> body;
        private Direction moveDirection;
        private Direction lastStepDirection;

        public Snake()
        {
            moveDirection = Direction.right;

            body = new LinkedList<SnakeBodyPart>();
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
            return body;
        }
        public void SetBodyPart(LinkedList<SnakeBodyPart> bodyPart)
        {
            body = bodyPart;
        }
        public Direction GetMoveDirection()
        {
            return moveDirection;
        }
        public void SetMoveDirection(Direction moveDirection)
        {
            this.moveDirection = moveDirection;
        }
        public Direction GetLastStepDirection()
        {
            return lastStepDirection;
        }
        public void SetLastStepDirection(Direction lastStepDirection)
        {
            this.lastStepDirection = lastStepDirection;
        }
    }
}
