using System;

namespace QuizApp
{
    public static class OutputHandler
    {
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static void  WriteQuizMenu(string title, string[] choices)
        {
            /*Write("Welcome !\r\n" +
                                "Enter the number of the quiz you want\r\n" +
                                "1. Animal quiz\r\n" +
                                "2. Car quiz\r\n" +
                                "3. Game quiz\r\n" +
                                "4. Geography quiz\r\n" +
                                "5. Mixed category quiz");*/
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
    }
}