namespace QuizApp
{
    public class GeographyDocument : QuizDocument
    {
        public override IQuiz CreateQuiz()
        {
           return new GeographyQuiz();
        }
    }
}