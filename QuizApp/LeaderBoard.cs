namespace QuizApp
{
    public class LeaderBoard
    {
        private long _userId;
        private string _userName;
        private double _score;
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

        public double Score
        {
            get => _score;
            set => _score = value;
        }

        
    }
}