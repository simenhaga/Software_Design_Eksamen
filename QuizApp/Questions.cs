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
            return string.Format("{0} {1} {2} {3}", this.question, this.optionOne, this.optionTwo, this.optionThree);
        }

        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        
    }
}