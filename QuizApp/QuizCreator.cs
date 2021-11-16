using System;
using System.Collections;


namespace QuizApp {
    public class QuizCreator {
        private static void CreateQuiz(string localPath, string filePath) {
            localPath = PathManager.FindPath(filePath);
            DrawQuiz(localPath);
        }
        private static void DrawQuiz(string localPath) {
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(localPath, ref list);
            // for (int i = 0; i < list.Count; i++) {
            //     Console.WriteLine(list[i]?.ToString());
            // }

            foreach (var question in list)
            {
                Console.WriteLine(question.ToString());
                InputHandler.Input();
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