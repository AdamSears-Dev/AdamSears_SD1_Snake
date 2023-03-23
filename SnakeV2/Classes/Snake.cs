using System.Collections.Generic;

namespace SnakeGame.Classes
{
    public class Snake
    {
        public List<int> X { get; private set; }
        public List<int> Y { get; private set; }

        public Snake()
        {
            X = new List<int>();
            Y = new List<int>();
            X.Add(10);
            Y.Add(10);
        }

        public void Move(int nextX, int nextY, bool ateFood)
        {
            X.Insert(0, nextX);
            Y.Insert(0, nextY);
            if (!ateFood)
            {
                X.RemoveAt(X.Count - 1);
                Y.RemoveAt(Y.Count - 1);
            }
        }
    }
}