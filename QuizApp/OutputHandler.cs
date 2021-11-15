using System;

namespace QuizApp
{
    public class OutputHandler
    {
        public string OutputToUser { get; set; }

        public static void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}