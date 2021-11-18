using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class QuestionValidation
    {
        public static void CheckAnswer(List<Questions> questionsList, User user)
        {
            
            foreach (var question in questionsList)
            {
                OutputHandler.Write(question.ToString());

                var answer = InputHandler.Input();
                if (answer == question.CorrectAnswer)
                {
                    OutputHandler.Write("Yaj");
                    user.UserScore += 50;
                }
                else
                {
                    OutputHandler.Write("Nej");
                    user.UserScore -= 15;
                }
            }

            Console.ReadKey();
        }
    }
}