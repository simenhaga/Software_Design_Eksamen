using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            User user = new User();
            var score = User.UserScore;
            var name = User.UserName;

            foreach (var question in qList)
            {
                //WRITE QUESTION AND READ ANSWER
                Console.WriteLine(question.ToString());
                var answer = Console.ReadLine();
                
                //CHECK IF THE ANSWER IS RIGHT
                if (answer == question.CorrectAnswer)
                {
                    Console.WriteLine("Yay");
                    score += 50;
                }
                else
                {
                    Console.WriteLine("Nay");
                    score -= 15;
                }
            }
            //TELL THE USER WHAT THEIR SCORE IS
            Console.WriteLine("Your got " + score + "points!");
            
            //SAVE SCORE
            var uScore = score.ToString();
            var uName = name;
            var tst = PathManager.FindPath(@"/TextFiles/UserScore.txt");

            //File.WriteAllText(tst, uScore);
            
            StreamWriter log;

            if (!File.Exists(tst))
            {
                log = new StreamWriter(tst);
            }
            else
            {
                log = File.AppendText(tst);
            }

// Write to the file:
            log.WriteLine(uScore);
            log.WriteLine(uName);

// Close the stream:
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
}