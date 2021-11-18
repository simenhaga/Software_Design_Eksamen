using System;
using System.Collections.Generic;
using System.Drawing;

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
            ShowLeaderBoard();
        }

        public static void ShowLeaderBoard()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Write("LEADERBOARD!!");
            Write("ALL SCORES: ");
            LeaderBoard.FindAllScores();
            Write("HIGHSCORE");
            LeaderBoard.showHighScore();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}