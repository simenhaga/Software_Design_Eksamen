using System.Dynamic;

namespace QuizApp
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long UserScore { get; set; }
        public User(string userName, long userScore)
        {
            UserName = userName;
            UserScore = userScore;
        }

        public static void CreateUser()
        {
            var userName = InputHandler.Input();
            var userScore = 0;
            OutputHandler.user = new(userName, userScore);
        }

        public static User GetUser()
        {
            return OutputHandler.user;
        }
    }
}