using System;

namespace QuizApp
{
    public class InputHandler {   
        string PlayerChoice { get; set; }
        private string AcceptInput { get; set; }


        /*public void HandelInput()
        {
            while ()
            { 
                PlayerChoice = GetUserInput();
                if (PlayerChoice == "1")
                {
                    //show quiz
                }

                if (PlayerChoice == "2") 
                {
                    //show quiz
                }

                if (PlayerChoice == "3")
                {
                    // show quiz    
                }

                if (PlayerChoice == "4")
                {
                    //show quiz
                }

                if (PlayerChoice == "5")
                {
                    //show mixed quiz
                }
            }
        }*/

        public static string ReadLine()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}