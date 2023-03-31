using System;
using System.Linq;
using SnakeGame.Classes;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.SetWindowSize(50, 25);
                Console.SetBufferSize(50, 25);

                int width = Console.WindowWidth - 1;
                int height = Console.WindowHeight - 1;

                Game game = new Game(width, height);
                Snake snake = game.Snake;
                Food food = game.Food;

                int directionX = 1;
                int directionY = 0;

                while (!game.GameOver)
                {
                    // Update game logic
                    GameLogic.UpdateGame(game, snake, food, directionX, directionY);

                    // Render the game
                    Renderer.Draw(game, snake, food);

                    // Update direction based on input
                    InputHandler.UpdateDirection(ref directionX, ref directionY);

                    // Sleep for a short time to control game speed
                    System.Threading.Thread.Sleep(game.SleepTime);
                }

                // Show game over message
                Console.Clear();
                Console.WriteLine("Game Over!");
                Console.WriteLine($"Score: {game.Score}");

                // Get user initials and save the score
                Console.Write("Enter your initials (3 characters): ");
                Console.CursorVisible = true;
                string input = Console.ReadLine();
                string initials = input.ToUpper().Substring(0, Math.Min(3, input.Length));
                Console.CursorVisible = false;

                HighScores.SaveScore(initials, game.Score);

                // Load and display high scores
                Console.WriteLine("\nHigh Scores:");
                var highScores = HighScores.LoadScores();
                var orderedScores = highScores.OrderByDescending(x => x.Score).Take(10);

                int rank = 1;
                foreach (var score in orderedScores)
                {
                    string userIndicator = score.Initials == initials ? " <--- " + initials : "";
                    Console.WriteLine($"{rank}. {score.Initials} - {score.Score}{userIndicator}");
                    rank++;
                }

                // Prompt the user to restart or quit
                Console.WriteLine("\nPress 'R' to restart or 'Q' to quit.");
                ConsoleKey key;
                do
                {
                    key = Console.ReadKey(true).Key;
                } while (key != ConsoleKey.R && key != ConsoleKey.Q);

                if (key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}
