using System;
using System.Collections;
using System.IO;
using System.Reflection;
using NUnit.Framework.Internal;


namespace QuizApp {
    public class ReadFromFile {


        private static void CreateQuiz(string localPath, string filePath) {
            localPath = PathManager.FindPath(filePath);
            DrawQuiz(localPath);
        }

        private static void DrawQuiz(string localPath) {
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(localPath, ref list);
            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i].ToString());
            }

            Console.ReadKey();
        }

        public static void CreateAnimalQuiz(string localPath, string filePath) {
            CreateQuiz(localPath, filePath);
        }
        
        public static void CreateCarsQuiz(string localPath, string filePath) {
            CreateQuiz(localPath, filePath);
        }
       
        public static void CreateGamesQuiz(string localPath, string filePath) {
            CreateQuiz(localPath, filePath);
        }
        
        public static void CreateGeographyQuiz(string localPath, string filePath) {
            CreateQuiz(localPath, filePath);
        }

        public static void CreateMixedQuiz(string localPath, string filePath) {
            CreateQuiz(localPath, filePath);
        }
    }
}