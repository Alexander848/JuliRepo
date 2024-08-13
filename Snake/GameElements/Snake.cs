using SnakeGame.GameElements.Utilities;

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
        private GUIData guiData = new GUIData();
        public int foodInStomach { get; set; }

        public Snake()
        {
            moveDirection = Direction.right;

            body = new LinkedList<SnakeBodyPart>();
            InitSnake();

            foodInStomach = 0;
        }

        // Setzt Snake Body Parts an initiale Position
        private void InitSnake()
        {
            body.AddFirst(new SnakeBodyPart(new Position(guiData.GetSnakeStartPositionTail().x, guiData.GetSnakeStartPositionTail().y)));
            body.AddFirst(new SnakeBodyPart(new Position(guiData.GetSnakeStartPositionHead().x, guiData.GetSnakeStartPositionHead().y)));
        }

        //Gives back position of snakeHead after one step
        public Position GetNextSnakeHeadPosition()
        {
            SnakeBodyPart firstElement = this.body.First();

            switch (this.GetMoveDirection())
            {
                case Direction.top:
                    return new Position(firstElement.position.x, firstElement.position.y - guiData.GetStandartRectangleHeight());
                case Direction.bottom:
                    return new Position(firstElement.position.x, firstElement.position.y + guiData.GetStandartRectangleHeight());
                case Direction.left:
                    return new Position(firstElement.position.x - guiData.GetStandartRectangleWidth(), firstElement.position.y);
                default:
                    return new Position(firstElement.position.x + guiData.GetStandartRectangleWidth(), firstElement.position.y);
            }
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
