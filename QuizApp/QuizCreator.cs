/*using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;


namespace QuizApp {
    public class QuizCreator {
        private static void CreateQuiz(string filePath)
        {
            var localPath = PathManager.GetPath(filePath);
            DrawQuiz(localPath);
        }
        
        private static void DrawQuiz(string localPath)
        {
            var qList = new List<Questions>();
            ReadFromFiles.ReadQuestions(localPath, qList);
            Quiz.GreetQuizUser();
            var name = userName;
            var score = User.UserScore;

            foreach (var question in qList)
            {
                //WRITE QUESTION AND READ ANSWER
                Console.WriteLine(question.ToString());
                var answer = Console.ReadLine();
                
                //CHECK IF THE ANSWER IS RIGHT
                if (answer == question.CorrectAnswer)
                { 
                    score += 50;
                }
                else
                {
                    score -= 15;
                }
            }
            
            //TELL THE USER WHAT THEIR SCORE IS
            Console.WriteLine("Your got " + score + " points!");
            
            // WRITE SCORE AND NAME TO FILE
            var scoreString = score.ToString();
            var path = PathManager.GetPath(@"/TextFiles/UserScore.txt");
            
            var log = !File.Exists(path) ? new StreamWriter(path) : File.AppendText(path);
            log.WriteLine(name);
            log.WriteLine(scoreString);
            log.Close();
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
}*/