namespace QuizApp
{
    public class Questions
    {
        public Questions(string question, string optionOne, string optionTwo, string optionThree) {
            Question = question;
            OptionOne = optionOne;
            OptionTwo = optionTwo;
            OptionThree = optionThree;
        }

        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        
    }
}