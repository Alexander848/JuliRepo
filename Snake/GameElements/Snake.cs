using SnakeGame.GameElements.Utilities;

enum Direction
{
    top, bottom, left, right
}

namespace SnakeGame.GameElements
{
    internal class Snake
    {
        private Direction _moveDirection;
        public Direction MoveDirection { get { return _moveDirection; } set { _moveDirection = value; } }
        private Direction _lastStepDirection;
        public Direction LastStepDirection { get { return _lastStepDirection; } set { _lastStepDirection = value; } }
        private GUIData guiData = new GUIData();
        public int foodInStomach { get; set; }
        public Queue<Position> snakeBody;

        public Snake()
        {
            MoveDirection = Direction.right;
            LastStepDirection = Direction.right;

            snakeBody = new Queue<Position>();
            snakeBody.Enqueue(guiData.GetSnakeStartPositionTail());
            snakeBody.Enqueue(guiData.GetSnakeStartPositionHead());


            foodInStomach = 0;
        }

        //Gives back position of snakeHead after one step
        public Position GetNextSnakeHeadPosition()
        {

            switch (this.MoveDirection)
            {
                case Direction.top:
                    return new Position(snakeBody.Last().x, snakeBody.Last().y - 1);
                case Direction.bottom:
                    return new Position(snakeBody.Last().x, snakeBody.Last().y + 1);
                case Direction.left:
                    return new Position(snakeBody.Last().x - 1, snakeBody.Last().y);
                default:
                    return new Position(snakeBody.Last().x + 1, snakeBody.Last().y);
            }
        }
    }
}
