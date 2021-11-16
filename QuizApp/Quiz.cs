namespace QuizApp
{
    public class Quiz
    {
       /* public Quiz()
        {
            OutputHandler.Write("Hello! Welcome to our super cool quiz application. \r\n" +
                                "Please enter your username");

            var userName = InputHandler.Input();

            if (userName == "taken")
            {
                do
                {
                    OutputHandler.Write("Username is already taken, please enter another username");
                    userName = InputHandler.Input();

                } while (userName == "taken");

                OutputHandler.Write("Welcome " + userName + "\r\n" + "Please choose a category");
            }
            else
            {
                OutputHandler.Write("Welcome " + userName + "!\r\n" +
                                    "Enter the number of the quiz you want\r\n" +
                                    "1. Animal quiz\r\n" +
                                    "2. Car quiz\r\n" +
                                    "3. Game quiz\r\n" +
                                    "4. Geography quiz\r\n" +
                                    "5. Mixed category quiz");
            }

            ChooseCategory();
        }*/

        /*public void ChooseCategory()
        {
            while (true)
            {
                const string animal = "You chose animal quiz";
                const string car = "You chose car quiz";
                const string game = "You chose game quiz";
                const string geography = "You chose geography quiz";
                const string mixed = "You chose mixed category quiz";
                const string invalidInput = "Invalid input, please enter number between 1-5";

                string chosenCategory = InputHandler.Input();
                switch (chosenCategory)
                {
                    case "1":
                        OutputHandler.Write(animal);
                        CreateAnimalQuiz();
                        break;
                    case "2":
                        OutputHandler.Write(car);
                        CreateCarsQuiz();
                        break;
                    case "3":
                        OutputHandler.Write(game);
                        CreateGamesQuiz();
                        break;
                    case "4":
                        OutputHandler.Write(geography);
                        CreateGeographyQuiz();
                        break;
                    case "5":
                        OutputHandler.Write(mixed);
                        ReadFromFiles.ReadQuestions();
                        break;
                    default:
                        OutputHandler.Write(invalidInput);
                        continue;
                }

                break;
            }
        }*/

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

            userName = InputHandler.Input();

            InputHandler.ValidateUser(userName);

            OutputHandler.Write("Welcome " + userName + "\r\n");
        }
    }
}