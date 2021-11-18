using System.Collections.Generic;

namespace QuizApp
{
    public class GeographyQuiz : IQuiz
    {
        public void Generate()
        {
            var filePath = PathManager.GetPath(@"/TextFiles/GeographyQuestions.txt");
            List<Questions> questionsList = new();
            ReadFromFiles.ReadQuestions(filePath, questionsList);
            QuestionValidation.CheckAnswer(questionsList, Quiz.GetUser());
            
        }
    }
}