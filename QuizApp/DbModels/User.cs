using System.Dynamic;

namespace QuizApp
{
    public class User
    {
        public long UserId { get; set; }
        public static string UserName { get; set; }
        public static long UserScore { get; set; }

        public override string ToString()
        {
            return $"{UserName}\r\n {UserScore}\r\n";
        }
    }
}