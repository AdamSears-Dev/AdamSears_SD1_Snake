using System;
using System.IO;
using System.Collections.Generic;

namespace SnakeGame.Classes
{
    public class HighScores
    {
        private const string FileName = "highscores.txt";

        public static void SaveScore(string initials, int score)
        {
            using (StreamWriter writer = File.AppendText(FileName))
            {
                writer.WriteLine($"{initials},{score}");
            }
        }

        public static List<(string Initials, int Score)> LoadScores()
        {
            List<(string Initials, int Score)> highScores = new List<(string Initials, int Score)>();

            if (File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 2)
                        {
                            string initials = parts[0];
                            if (int.TryParse(parts[1], out int score))
                            {
                                highScores.Add((initials, score));
                            }
                        }
                    }
                }
            }

            return highScores;
        }
    }
}
