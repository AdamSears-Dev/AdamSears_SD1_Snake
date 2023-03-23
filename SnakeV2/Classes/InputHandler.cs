using System;

namespace SnakeGame.Classes
{
    public class InputHandler
    {
        public static void UpdateDirection(ref int directionX, ref int directionY)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow && directionX != 1)
                {
                    directionX = -1;
                    directionY = 0;
                }
                else if (key.Key == ConsoleKey.RightArrow && directionX != -1)
                {
                    directionX = 1;
                    directionY = 0;
                }
                else if (key.Key == ConsoleKey.UpArrow && directionY != 1)
                {
                    directionX = 0;
                    directionY = -1;
                }
                else if (key.Key == ConsoleKey.DownArrow && directionY != -1)
                {
                    directionX = 0;
                    directionY = 1;
                }
            }
        }
    }
}
