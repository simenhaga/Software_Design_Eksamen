using System;

namespace QuizApp
{
    public static class InputHandler {
        public static string Input()
        {
            Console.Write(">> ");
            return Console.ReadLine();
        }

        public static void ValidateUser(string userName)
        {
            while (userName == "taken")
            {
                OutputHandler.Write("Username is already taken, please enter another username");
                userName = Input();

            }
        }

        public static Command ReadMenuChoices(out string param)
        {
            Command command;

            string[] input = Input().ToLower().Split(' ');
            if (input.Length > 1)
            {
                param = input[1];
            }
            else
            {
                param = "";
            }

            switch (input[0])
            {
                case "Game quiz":
                    command = Command.GameQuiz;
                    break;
                case "Animal quiz":
                    command = Command.AnimalsQuiz;
                    break;
                case "Car quiz":
                    command = Command.CarQuiz;
                    break;
                case "Geography quiz":
                    command = Command.GeographyQuiz;
                    break;
                case "Mixed quiz":
                    command = Command.MixedQuiz;
                    break;
                case "Quit":
                    command = Command.Quit;
                    break;
                default:
                    command = Command.InvalidChoice;
                    break;
            }

            return command;
        }
    }
}