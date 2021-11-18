using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class LeaderBoard
    {
        private string _username;
        private long _score;
        private long _highscore;

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public long Score
        {
            get => _score;
            set => _score = value;
        }

        public long Highscore
        {
            get => _highscore;
            set => _highscore = value;
        }

        public static void showHighScore()
        {
            var scores = FindAllScores();

            int highest = scores[0];
            for (int i = 0; i < scores.Count; i++)
            {
                if (highest < scores[i])
                {
                    highest = scores[i];
                }
            }
            Console.WriteLine(highest);
        }

        public static List<int> FindAllScores()
        {
            List<User> user = ReadFromFiles.RetrieveUser();
            List<int> scores = new();
            foreach (var users in user)
            {
                Console.WriteLine(users.UserScore);
                scores.Add((int) users.UserScore);
            }
            return scores;
        }
    }
}