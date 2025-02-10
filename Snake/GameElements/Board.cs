using SnakeGame.GameElements.Utilities;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SnakeGame.GameElements
{
    internal class Board
    {
        public GameElement[][] boardElements { get; set; }
        private GUIData guiData = new GUIData();
        private Size boardsizeInElements = new Size(40, 20);
        private Size interfaceInElements = new Size(40, 3);

        public Board()
        {
            boardElements = new GameElement[boardsizeInElements.Width][];
            for (int i = 0; i < boardElements.Length; i++)
            {
                //boardElements[i] = new GameElement[guiData.GameFrameSize.Height / guiData.GetStandartRectangleHeight()];
                boardElements[i] = new GameElement[boardsizeInElements.Height];

                for (int j = 0; j < boardElements[i].Length; j++)
                {
                    boardElements[i][j] = new EmptyArea(new Position(i, j));
                }
            }
        }

        public GameElement GetBoardElement(Position position)
        {
            return boardElements[position.x][position.y];
        }

        // Puts Rocks into their initial position
        public void PlaceRocks()
        {
            if (this.boardElements == null || this.boardElements.Length == 0)
            {
                return;
            }

            // Fill upper row with rocks
            for (int i = 0; i < this.boardElements.Length; i++)
            {
                Position rockPosition = new Position(i, 0);
                this.boardElements[i][0] = new Rock(rockPosition);
            }

            //fill lower rock with rocks
            for (int i = 0; i < this.boardElements.Length; i++)
            {
                Position rockPosition = new Position(i, (this.boardElements[i].Length - 1));
                this.boardElements[i][this.boardElements[i].Length - 1] = new Rock(rockPosition);
            }

            //fill left side with rocks
            for (int i = 0; i < this.boardElements[0].Length; i++)
            {
                Position rockPosition = new Position(0, i);
                this.boardElements[0][i] = new Rock(rockPosition);
            }
            //fill right side with rocks
            for (int i = 0; i < this.boardElements[0].Length; i++)
            {
                Position rockPosition = new Position((this.boardElements.Length - 1), i);
                this.boardElements[this.boardElements.Length - 1][i] = new Rock(rockPosition);
            }
        }

        // Places Snake into its initial Position
        public void PlaceSnake()
        {
            Position headPosition = new Position(guiData.GetSnakeStartPositionHead().x, guiData.GetSnakeStartPositionHead().y);
            Position tailPosition = new Position(guiData.GetSnakeStartPositionTail().x, guiData.GetSnakeStartPositionTail().y);

            this.boardElements[headPosition.x][headPosition.y] = new SnakeBodyPart(headPosition);
            this.boardElements[tailPosition.x][tailPosition.y] = new SnakeBodyPart(tailPosition);
        }

        // Places Food into an random empty space, but not directly infront of the snake
        public void PlaceFood(Snake snake)
        {
            GameElement[][] elements = this.boardElements;
            bool foodPlaced = false;
            Random rnd = new Random();

            Position nextSnakeHeadPosition = snake.GetNextSnakeHeadPosition();

            //Tries to randomly find an empty space on board to place food
            while (!foodPlaced)
            {
                int xCoordinate = rnd.Next(0, elements.Length);
                int yCoordinate = rnd.Next(0, elements[0].Length);

                if (elements[xCoordinate][yCoordinate].GetType() == typeof(EmptyArea) && new Position(xCoordinate, yCoordinate) != nextSnakeHeadPosition)
                {
                    Position foodPosition = new Position(xCoordinate, yCoordinate);
                    elements[xCoordinate][yCoordinate] = new Food(foodPosition);
                    foodPlaced = true;
                }
            }
        }

        public void DrawBoard(Graphics graphics, Rectangle screenBounds)
        {
            // Board has a height dividable by 23. 20 Parts game, 3 parts interface
            int totalHeightInElements = boardsizeInElements.Height + interfaceInElements.Height;

            Size rectangleSize;
            if (GUIData.FullScreen)
            {
                rectangleSize = new Size(screenBounds.Width / boardsizeInElements.Width, screenBounds.Height / totalHeightInElements);
            } 
            else
            {
                rectangleSize = new Size(GUIData.WindowSize.Width / boardsizeInElements.Width, GUIData.WindowSize.Height / totalHeightInElements);
            }

            for (int i = 0; i < this.boardElements.Length; i++)
            {
                for (int j = 0; j < this.boardElements[i].Length; j++)
                {
                    GameElement element = boardElements[i][j];
                    if (element != null)
                    {
                        if (element.GetType() == typeof(EmptyArea))
                        {
                            graphics.FillRectangle(guiData.WhiteBrush, i * rectangleSize.Width, j * rectangleSize.Height,
                                rectangleSize.Width, rectangleSize.Height);
                        }
                        else if (element.GetType() == typeof(Rock))
                        {
                            graphics.FillRectangle(guiData.GreyBrush, i * rectangleSize.Width, j * rectangleSize.Height,
                                rectangleSize.Width, rectangleSize.Height);
                        }
                        else if (element.GetType() == typeof(SnakeBodyPart))
                        {
                            graphics.FillRectangle(guiData.BlueBrush, i * rectangleSize.Width, j * rectangleSize.Height,
                                rectangleSize.Width, rectangleSize.Height);
                        }
                        else if (element.GetType() == typeof(Food))
                        {
                            graphics.FillRectangle(guiData.RedBrush, i * rectangleSize.Width, j * rectangleSize.Height,
                                rectangleSize.Width, rectangleSize.Height);
                        }
                    }
                }
            }
        }

        private void RemoveLastSnakeElement(ref Snake snake)
        {
            Position positionLastSnakeElement = snake.snakeBody.Dequeue();
            if (positionLastSnakeElement == null) return;
            this.boardElements[positionLastSnakeElement.x][positionLastSnakeElement.y] = new EmptyArea(positionLastSnakeElement);
        }

        private void AddFirstSnakeElement(ref Snake snake, Position position)
        {
            if (position == null) return;
            snake.snakeBody.Enqueue(position);
            this.boardElements[position.x][position.y] = new SnakeBodyPart(position);
        }

        // 
        public bool MoveSnakeAndDetectCollision(ref int score, ref Snake snake)
        {
            snake.LastStepDirection = snake.MoveDirection;

            // If the snake recently ate, the last snake element will not be removed, so the snake gets longer
            if (snake.foodInStomach > 0)
            {
                snake.foodInStomach--;
            }
            else
            {
                RemoveLastSnakeElement(ref snake);
            }

            // Checks collision and adds new head element
            Position nextHeadPosition = snake.GetNextSnakeHeadPosition();
            if (nextHeadPosition == null) return false;

            GameElement elementCurrentlyAtNextPosition = this.GetBoardElement(nextHeadPosition);
            if (elementCurrentlyAtNextPosition == null) return false; ;

            if (elementCurrentlyAtNextPosition.GetType() == typeof(SnakeBodyPart))
            {
                return false;
            }
            else if (elementCurrentlyAtNextPosition.GetType() == typeof(Rock))
            {
                return false;
            } else if (elementCurrentlyAtNextPosition.GetType() == typeof(EmptyArea))
            {
                AddFirstSnakeElement(ref snake, nextHeadPosition);
                return true;
            } else if(elementCurrentlyAtNextPosition.GetType() == typeof(Food))
            {
                snake.foodInStomach++;
                score++;
                AddFirstSnakeElement(ref snake, nextHeadPosition);
                PlaceFood(snake);
                return true;
            } 

            return false;
        }
    }
}