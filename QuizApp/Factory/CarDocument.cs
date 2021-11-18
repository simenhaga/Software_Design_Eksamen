namespace QuizApp
{
    public class CarDocument : QuizDocument
    {
        public override IQuiz CreateQuiz()
        {
            return new CarQuiz();
        }
    }
}