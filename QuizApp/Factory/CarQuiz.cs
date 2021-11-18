using System.Collections.Generic;

namespace QuizApp
{
    public class CarQuiz : IQuiz
    {
        public void Generate()
        {
            var filePath = PathManager.GetPath(@"/TextFiles/CarsQuestions.txt");
            List<Questions> questionsList = new();
            ReadFromFiles.ReadQuestions(filePath, questionsList);
            QuestionValidation.CheckAnswer(questionsList);
        }
    }
}