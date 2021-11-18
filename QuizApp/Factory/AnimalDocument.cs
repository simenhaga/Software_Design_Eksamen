namespace QuizApp
{
    public class AnimalDocument : QuizDocument

    {
        public override IQuiz CreateQuiz()
        {
            return new AnimalQuiz();
        }
    }
}