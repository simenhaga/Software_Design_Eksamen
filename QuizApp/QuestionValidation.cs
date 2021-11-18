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
                //EVENTUELT FJERN BLOKKEN UNDER
                switch (answer)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Unacceptable value! Enter a number between 1 and 3!");
                        answer = Console.ReadLine();
                        
                        break;
                }
                //TIL HIT
                
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
        }
    }
}