using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;


namespace QuizApp {
    public class QuizCreator {
        private static void CreateQuiz(string filePath)
        {
            var localPath = PathManager.FindPath(filePath);
            DrawQuiz(localPath);
        }
        
        private static void DrawQuiz(string localPath)
        {
            var qList = new List<Questions>();
            ReadFromFiles.ReadQuestions(localPath, qList);
            
            
            foreach (var question in qList)
            {
                //WRITE QUESTION AND READ ANSWER
                Console.WriteLine(question.ToString());
                var answer = Console.ReadLine();
                
                //CHECK IF THE ANSWER IS RIGHT
                if (answer == question.CorrectAnswer)
                {
                    Console.WriteLine("Yay");
                    User.UserScore += 50;
                }
                else
                {
                    Console.WriteLine("Nay");
                    User.UserScore -= 15;
                }
            }
            //TELL THE USER WHAT THEIR SCORE IS
            Console.WriteLine("Your score: " + User.UserScore);
        }
        
        
        public static void CreateAnimalQuiz(string filePath) {
            CreateQuiz(filePath);
        }
        
        public static void CreateCarsQuiz(string filePath) {
            CreateQuiz(filePath);
        }
       
        public static void CreateGamesQuiz(string filePath) {
            CreateQuiz(filePath);
        }
        
        public static void CreateGeographyQuiz(string filePath) {
            CreateQuiz(filePath);
        }

        public static void CreateMixedQuiz(string filePath) {
            CreateQuiz(filePath);
        }
    }
}