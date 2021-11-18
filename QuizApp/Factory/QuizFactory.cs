namespace QuizApp
{
    public class QuizFactory : QuizDocument
    {
      
        public override IQuiz CreateQuiz()
        {
            return new AnimalQuiz();
        }
    }
}