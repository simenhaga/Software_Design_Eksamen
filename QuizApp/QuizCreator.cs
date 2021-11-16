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
            List<Questions> qList = new List<Questions>();
            ReadFromFiles.ReadQuestions(localPath, qList);
            foreach (var question in qList)
            {
                //Read one question at a time
                Console.WriteLine(question.ToString());
                var answer = Console.ReadLine();
                
                if (answer == question.CorrectAnswer)
                {
                    Console.WriteLine("Yay");
                }
                else
                {
                    Console.WriteLine("Nay");
                }

                //Dealing with wrong input
                
                
                //Check if the input is correct and update score 
                // if (answer == correctA)
                // {
                //     User.UserScore += 10;
                //     Console.WriteLine("Score Updatet"); //bare forå teste
                // }
                
                
            }
            Console.ReadKey();
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