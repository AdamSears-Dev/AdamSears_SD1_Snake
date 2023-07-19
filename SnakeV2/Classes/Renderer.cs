using System;

namespace SnakeGame.Classes
{
    public class Renderer
    {
        public static void Draw(Game game, Snake snake, Food food)
        {
            // Get console window size
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;

            // Update game width and height to match console window size
            game.Width = windowWidth - 1;
            game.Height = windowHeight - 2; // Minus 2 to leave space for the score

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
                // Make sure snake is within game bounds
                if (snake.X[i] >= 0 && snake.X[i] <= game.Width && snake.Y[i] >= 0 && snake.Y[i] <= game.Height)
                {
                    Console.SetCursorPosition(snake.X[i], snake.Y[i]);
                    Console.Write("O");
                }
            }

            // Draw the food
            Console.ForegroundColor = ConsoleColor.Red;
            // Make sure food is within game bounds
            if (food.X >= 0 && food.X <= game.Width && food.Y >= 0 && food.Y <= game.Height)
            {
                Console.SetCursorPosition(food.X, food.Y);
                Console.Write("+");
            }

            // Update the score
            Console.SetCursorPosition(0, game.Height + 1);
            Console.Write("Score: " + game.Score);
        }
    }
}
