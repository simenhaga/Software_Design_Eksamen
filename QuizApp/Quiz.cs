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