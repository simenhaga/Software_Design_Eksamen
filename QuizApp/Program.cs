
using System;

namespace QuizApp {
    class Program {
        public static void Main(string[] args)
        {
            var s = new QuizFactory().CreateQuiz();
            s.Generate();
            //new Quiz().Start();
        }
       
    }
}