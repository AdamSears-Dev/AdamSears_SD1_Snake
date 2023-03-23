namespace SnakeGame.Classes
{
    public class GameLogic
    {
        public static void UpdateGame(Game game, Snake snake, Food food, int directionX, int directionY)
        {
            int nextX = snake.X[0] + directionX;
            int nextY = snake.Y[0] + directionY;

            if (nextX < 1 || nextX > game.Width - 1 || nextY < 1 || nextY > game.Height - 1)
            {
                game.SetGameOver(true);
            }
            else if (nextX == food.X && nextY == food.Y)
            {
                game.IncreaseScore();
                snake.Move(nextX, nextY, true);
                food.Respawn(game.Width, game.Height);
                game.UpdateSleepTime();
            }
            else
            {
                snake.Move(nextX, nextY, false);
            }
        }
    }
}
