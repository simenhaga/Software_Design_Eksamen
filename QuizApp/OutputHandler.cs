using System;

namespace QuizApp
{
    public static class OutputHandler
    {
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static void  WriteQuizMenu()
        {
            Write("Welcome !\r\n" +
                                "Enter the number of the quiz you want\r\n" +
                                "1. Animal quiz\r\n" +
                                "2. Car quiz\r\n" +
                                "3. Game quiz\r\n" +
                                "4. Geography quiz\r\n" +
                                "5. Mixed category quiz");
        }
    }
}