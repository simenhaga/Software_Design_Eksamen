using System;

namespace QuizApp
{
    public static class OutputHandler
    {
        public static User user;
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static void  WriteQuizMenu(string title, string[] choices)
        {
            Write("");
            Write(title);
            Write("======================================================");
            Write("Available commands: ");
            foreach (var choice in choices)
            {
                Write(choice);
            }
            Write("======================================================");
            Write("Enter a command to choose category\n or (quit) to end program");
            Write("======================================================");

        }


        public static void GreetQuizUser()
        {
            Write("Hello! Welcome to our super cool quiz application. \r\n" +
                                "Please enter your username");

            User.CreateUser();

            InputHandler.ValidateUser(user);

            Write("Welcome " + user.UserName + "\r\n");
        }
    }
}