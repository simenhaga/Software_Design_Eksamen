namespace QuizApp
{
    public class Questions
    {
        string question;
        string optionOne;
        string optionTwo;
        string optionThree;
        
        public Questions(string question, string optionOne, string optionTwo, string optionThree) {
            this.question = question;
            this.optionOne = optionOne;
            this.optionTwo = optionTwo;
            this.optionThree = optionThree;
        }
        
        public override string ToString()
        {
            return string.Format("{0}\r\n 1. {1}\r\n 2. {2}\r\n 3. {3}\r\n", question, optionOne, optionTwo, optionThree);
        }

        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        
    }
}