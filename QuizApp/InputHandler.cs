using System;

namespace QuizApp
{
    public class InputHandler {
        public static string Input()
        {
            Console.Write(">> ");
            return Console.ReadLine();
        }
    }
}