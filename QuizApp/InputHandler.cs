using System;

namespace QuizApp
{
    public static class InputHandler {
        public static string Input()
        {
            Console.Write(">> ");
            return Console.ReadLine();
        }

        public static void ValidateUser(User user)
        {
            if (PathManager.GetPath(@"/TextFiles/UserScore.txt") != String.Empty)
            {
                var userList = ReadFromFiles.RetrieveUser();
                foreach (var name in userList)
                {
                    while (user.UserName == name.UserName)
                    {
                        OutputHandler.Write("Username is already taken, please enter another username");
                        user.UserName = Input();
                    }
                }
            }
            else
            {
                user.UserName = Input();
            }
        }

        public static Command ReadMenuChoices(out string param)
        {
            Command command;

            string[] input = Input().ToLower().Split(' ');
            if (input.Length > 1)
            {
                param = input[1];
            }else {
                param = "";
            }

            switch (input[0])
            {
                case "game":
                    command = Command.GameQuiz;
                    break;
                case "animal":
                    command = Command.AnimalsQuiz;
                    break;
                case "car":
                    command = Command.CarQuiz;
                    break;
                case "geography":
                    command = Command.GeographyQuiz;
                    break;
                case "mixed":
                    command = Command.MixedQuiz;
                    break;
                case "quit":
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