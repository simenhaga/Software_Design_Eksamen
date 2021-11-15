using System;

namespace QuizApp
{
    public class OutputHandler
    {
        public string OutputToUser { get; set; }

        public void Write(string userOutput)
        {
            OutputToUser = userOutput;
            Console.WriteLine(userOutput);
        }
    }
}