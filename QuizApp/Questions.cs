namespace QuizApp
{
    public class Questions
    {
        private string _question;
        private string _optionOne;
        private string _optionTwo;
        private string _optionThree;
        
        public Questions(string question, string optionOne, string optionTwo, string optionThree) {
            _question = question;
            _optionOne = optionOne;
            _optionTwo = optionTwo;
            _optionThree = optionThree;
        }
        
        public override string ToString()
        {
            return string.Format("{0}\r\n 1. {1}\r\n 2. {2}\r\n 3. {3}\r\n", _question, _optionOne, _optionTwo, _optionThree);
        }

        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        
    }
}