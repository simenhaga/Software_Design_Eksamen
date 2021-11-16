using System.Dynamic;

namespace QuizApp
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public static long UserScore { get; set; }
    }
}