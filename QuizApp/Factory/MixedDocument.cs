namespace QuizApp
{
    public class MixedDocument : QuizDocument
    {
        public override IQuiz CreateQuiz()
        {
            return new MixedQuiz();
        }
    }
}