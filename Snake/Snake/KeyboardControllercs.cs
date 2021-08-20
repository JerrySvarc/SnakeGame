using System;

namespace Snake
{
    class KeyboardController : IPlayerController
    {
        public ConsoleKey? key;
        Keyboard keyboard = Keyboard.Instance;
        public bool reversed;
        public void Update()
        {
            keyboard.HasKey();
            key = keyboard.GetKey();
        }

        public Direction? GetInput()
        {
            if (reversed == false)
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        return Direction.UP;
                    case ConsoleKey.S:
                        return Direction.DOWN;
                    case ConsoleKey.A:
                        return Direction.LEFT;
                    case ConsoleKey.D:
                        return Direction.RIGTH;
                    default:
                        return null;
                }
            }
            else
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        return Direction.DOWN;
                    case ConsoleKey.S:
                        return Direction.UP;
                    case ConsoleKey.A:
                        return Direction.RIGTH;
                    case ConsoleKey.D:
                        return Direction.LEFT;
                    default:
                        return null;
                }
            }

        }

        public bool IsEndGame()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            reversed = !reversed;
        }
    }
}
