namespace QuizApp
{
    public class Questions
    {
        /*private string _question;
        private string _optionOne;
        private string _optionTwo;
        private string _optionThree;
        private string _correctAnswer;
        */
        
        public Questions(string question, string optionOne, string optionTwo, string optionThree, string correctAnswer) {
            Question = question;
            OptionOne = optionOne;
            OptionTwo = optionTwo;
            OptionThree = optionThree;
            CorrectAnswer = correctAnswer;
        }
        
        
        public override string ToString()
        {
            return string.Format("{0}\r\n 1. {1}\r\n 2. {2}\r\n 3. {3}\r\n", Question, OptionOne, OptionTwo, OptionThree);
        }

        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        
        public string CorrectAnswer { get; set; }
        
    }
}