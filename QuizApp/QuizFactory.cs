namespace QuizApp
{
    public class QuizFactory 
    {
        public IQuiz GetQuiz()
        {

            return new AnimalQuiz();
        }
    }
}