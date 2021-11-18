using System.Collections.Generic;

namespace QuizApp
{
    public class GameQuiz : IQuiz
    {
        public void Generate()
        {
            var filePath = PathManager.GetPath(@"/TextFiles/GamesQuestions.txt");
            List<Questions> questionsList = new();
            ReadFromFiles.ReadQuestions(filePath, questionsList);
            QuestionValidation.CheckAnswer(questionsList, Quiz.GetUser());
        }
    }
}