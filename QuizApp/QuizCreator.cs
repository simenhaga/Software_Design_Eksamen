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
                //Read one question at a time
                Console.WriteLine(question.ToString());
                var answer = InputHandler.Input(); //eller =console.Readline()
                //var correctA = Questions.CorrectAnswer; //fiks dette

                //Dealing with wrong input
                Console.WriteLine(answer == ReadFromFiles.ReadAnswer(ref list)
                    ? "You have answered correctly!"
                    : "Your answer is wrong");
                
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