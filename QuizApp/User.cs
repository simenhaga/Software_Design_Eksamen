using System.Dynamic;

namespace QuizApp
{
    public class User
    {
        private long _userId;
        private string _userName;
        public long UserId
        {
            get => _userId;
            set => _userId = value;
        }

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
    }
}