using System;
using System.Collections;


namespace QuizApp {
    public class QuizCreator {
        private static void CreateQuiz(string filePath)
        {
            var localPath = PathManager.FindPath(filePath);
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