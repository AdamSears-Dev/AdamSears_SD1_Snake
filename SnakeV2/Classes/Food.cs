using System;

namespace SnakeGame.Classes
{
    public class Food
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Food()
        {
            X = 20;
            Y = 10;
        }

        public void Respawn(int width, int height)
        {
            Random rnd = new Random();
            X = rnd.Next(2, width - 2);
            Y = rnd.Next(3, height - 3);
        }
    }
}