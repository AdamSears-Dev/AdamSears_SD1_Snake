using System;

namespace SnakeGame.Classes
{
    public class Renderer
    {
        public static void Draw(Game game, Snake snake, Food food)
        {
            Console.Clear();

            // Draw the border
            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 0; x <= game.Width; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("-");
                Console.SetCursorPosition(x, game.Height);
                Console.Write("-");
            }
            for (int y = 0; y <= game.Height; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("|");
                Console.SetCursorPosition(game.Width, y);
                Console.Write("|");
            }

            // Draw the snake
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < snake.X.Count; i++)
            {
                Console.SetCursorPosition(snake.X[i], snake.Y[i]);
                Console.Write("O");
            }

            // Draw the food
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(food.X, food.Y);
            Console.Write("+");

            // Update the score
            Console.SetCursorPosition(0, game.Height);
            Console.Write("Score: " + game.Score);
        }
    }
}
