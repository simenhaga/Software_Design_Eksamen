using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class QuestionValidation
    {
        public static void CheckAnswer(List<Questions> questionsList)
        {
            foreach (var question in questionsList)
            {
                OutputHandler.Write(question.ToString());

                var answer = InputHandler.Input();
                if (answer == question.CorrectAnswer)
                {
                    OutputHandler.Write("Yaj");
                }
                else
                {
                    OutputHandler.Write("Nej");
                }
            }

            Console.ReadKey();
        }
    }
}