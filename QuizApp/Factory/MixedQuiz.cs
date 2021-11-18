using System.Collections.Generic;

namespace QuizApp
{
    public class MixedQuiz : IQuiz
    {
        public void Generate()
        {
            var filePath = PathManager.GetPath(@"/TextFiles/MixedQuestions.txt");
            List<Questions> questionsList = new();
            ReadFromFiles.ReadQuestions(filePath, questionsList);
            QuestionValidation.CheckAnswer(questionsList, User.GetUser());
            Quiz.SaveNameAndScore();
        }
    }
}