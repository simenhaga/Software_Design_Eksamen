namespace QuizApp
{
    public class GameDocument : QuizDocument
    {
        public override IQuiz CreateQuiz()
        {
            return new GameQuiz();
        }
    }
}