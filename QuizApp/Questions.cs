namespace QuizApp
{
    public class Questions
    {

        public Questions(string question, string optionOne, string optionTwo, string optionThree, string correctAnswer) {
            Question = question;
            OptionOne = optionOne;
            OptionTwo = optionTwo;
            OptionThree = optionThree;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            return $"{Question}\r\n 1. {OptionOne}\r\n 2. {OptionTwo}\r\n 3. {OptionThree}\r\n";
        }

        public string Question { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        
        public string CorrectAnswer { get; set; }
        
    }
}