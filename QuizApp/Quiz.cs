namespace QuizApp
{
    public class Quiz
    { 
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
                        string asd = param;
                        OutputHandler.Write("You chose the animal quiz");
                        QuizCreator.CreateAnimalQuiz( @"/TextFiles/AnimalQuestions.txt");
                        break;
                    
                    case Command.GameQuiz:
                        OutputHandler.Write("You chose the game quiz");
                        QuizCreator.CreateGamesQuiz(@"/TextFiles/GamesQuestions.txt");
                        break;
                    
                    case Command.GeographyQuiz:
                        OutputHandler.Write("You chose the geography quiz");
                        QuizCreator.CreateGeographyQuiz(@"/TextFiles/GeographyQuestions.txt");
                        break;
                    
                    case Command.CarQuiz:
                        OutputHandler.Write("You chose the car quiz");
                        QuizCreator.CreateCarsQuiz(@"/TextFiles/CarsQuestions.txt");
                        break;
                    
                    case Command.MixedQuiz:
                        OutputHandler.Write("You chose the mixed quiz");
                        QuizCreator.CreateMixedQuiz(@"/TextFiles/MixedQuestions.txt");
                        break;
                }
            }
        }

        private Command Menu(out string param)
        {
            GreetQuizUser(out var userName);

            string[] choices =
            {
                "Game....... starts a quiz with game based questions",
                "Animal..... starts a quiz with animal questions",
                "Car........ starts a quiz with car questions",
                "Geography.. starts a quiz with Geography questions",
                "Mixed...... starts a quiz with mixed questions",
                "Quit....... ends the program"
            };
            OutputHandler.WriteQuizMenu("THE QUIZ APPLICATION\n Welcome: " + userName +"", choices);
            
            return InputHandler.ReadMenuChoices(out param);
        }

        private static void GreetQuizUser(out string userName)
        {
            OutputHandler.Write("Hello! Welcome to our super cool quiz application. \r\n" +
                                "Please enter your username");

            /*
            Burde ikke dette være User sit userName?
            Typ User.userName = InputHandler.Input();   
            */
            userName = InputHandler.Input();

            InputHandler.ValidateUser(userName);

            OutputHandler.Write("Welcome " + userName + "\r\n");
        }
    }
}