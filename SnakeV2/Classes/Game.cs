using System;
using SnakeGame.Classes;

namespace SnakeGame
{
    public class Game
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Score { get; private set; }
        public bool GameOver { get; private set; }
        public int SleepTime { get; private set; }

        public Snake Snake { get; private set; }
        public Food Food { get; private set; }

        public Game(int width, int height)
        {
            Width = width;
            Height = height;
            Score = 0;
            GameOver = false;
            SleepTime = 150;
            Snake = new Snake();
            Food = new Food();
        }

        public void IncreaseScore()
        {
            Score++;
        }

        public void UpdateSleepTime()
        {
            SleepTime -= 5;
            if (SleepTime < 5) SleepTime = 5;
        }

        public void SetGameOver(bool status)
        {
            GameOver = status;
        }
    }
}

