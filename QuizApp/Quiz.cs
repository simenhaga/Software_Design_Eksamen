using System;
using System.IO;
using Google.Protobuf.WellKnownTypes;

namespace QuizApp
{
    public class Quiz
    {
        private static User user;
        public void Start()
        {
            var command = Command.InvalidChoice;

            while (command != Command.Quit)
            {
                command = Menu(out string param);

                switch (command)
                {
                    case Command.InvalidChoice:
                        OutputHandler.Write("Not a valid choice");
                        break;
                    
                    case Command.AnimalsQuiz:
                        OutputHandler.Write("You chose the animal quiz");
                        var animalQuiz = new AnimalDocument().CreateQuiz();
                        animalQuiz.Generate();
                        break;
                    
                    case Command.GameQuiz:
                        OutputHandler.Write("You chose the game quiz");
                        var gameQuiz = new GameDocument().CreateQuiz();
                        gameQuiz.Generate();
                        break;
                    
                    case Command.GeographyQuiz:
                        OutputHandler.Write("You chose the geography quiz");
                        var geographyQuiz = new GeographyDocument().CreateQuiz();
                        geographyQuiz.Generate();
                        break;
                    
                    case Command.CarQuiz:
                        OutputHandler.Write("You chose the car quiz");
                        var carQuiz = new CarDocument().CreateQuiz();
                        carQuiz.Generate();
                        break;
                    
                    case Command.MixedQuiz:
                        OutputHandler.Write("You chose the mixed quiz");
                        var mixedQuiz = new MixedDocument().CreateQuiz();
                        mixedQuiz.Generate();
                        break;
                }
            }
        }

        public static Command Menu(out string param)
        {
            GreetQuizUser();

            string[] choices =
            {
                "Game....... starts a quiz with game based questions",
                "Animal..... starts a quiz with animal questions",
                "Car........ starts a quiz with car questions",
                "Geography.. starts a quiz with Geography questions",
                "Mixed...... starts a quiz with mixed questions",
                "Quit....... ends the program"
            };
            OutputHandler.WriteQuizMenu("THE QUIZ APPLICATION\n Welcome: " + user.UserName +"", choices);
            
            return InputHandler.ReadMenuChoices(out param);
        }

        public static void GreetQuizUser()
        {
            OutputHandler.Write("Hello! Welcome to our super cool quiz application. \r\n" +
                                "Please enter your username");

            CreateUser();
            /*
            Burde ikke dette være User sit userName?
            Typ User.userName = InputHandler.Input();   
            */

            InputHandler.ValidateUser(user.UserName);

            OutputHandler.Write("Welcome " + user.UserName + "\r\n");
        }

        public static void CreateUser()
        {
            var userName = InputHandler.Input();
            var userScore = 0;
            user = new(userName, userScore);
        }

        public static User GetUser()
        {
            return user;
        }

        public static void SaveNameAndScore()
        {
            //TELL THE USER WHAT THEIR SCORE IS
            Console.WriteLine("Your got " + user.UserScore + " points!");
            
            // WRITE SCORE AND NAME TO FILE
            var scoreString = user.UserScore.ToString();
            var path = PathManager.GetPath(@"/TextFiles/UserScore.txt");
            
            var log = !File.Exists(path) ? new StreamWriter(path) : File.AppendText(path);
            log.WriteLine(user.UserName);
            log.WriteLine(scoreString);
            log.Close();
        }
    }
}