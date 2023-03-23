using System;
using SnakeGame.Classes;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
