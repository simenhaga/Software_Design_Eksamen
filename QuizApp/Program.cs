using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using static QuizApp.ReadFromFile;

namespace QuizApp {
    class Program {
        public static void Main(string[] args)
        {
            OutputHandler.Write("Hello! Welcome to our super cool quiz application. \r\n" + 
                                "Please enter your username");

            var userName = InputHandler.Input();

            if (userName == "taken")
            {
                do
                {
                    OutputHandler.Write("Username is already taken, please enter another username");
                    userName = InputHandler.Input();

                } while (userName == "taken");
                
                OutputHandler.Write("Welcome " + userName + "\r\n" + "Please choose a category");
            }
            else
            {
                OutputHandler.Write("Welcome " + userName + "!\r\n" + 
                                  "Enter the number of the quiz you want\r\n" +
                                  "1. Animal quiz\r\n" +
                                  "2. Car quiz\r\n" +
                                  "3. Game quiz\r\n" +
                                  "4. Geography quiz\r\n" +
                                  "5. Mixed category quiz");
            }

            ChooseCategory();
        }
        private static void ChooseCategory()
        {
            OutputHandler outputHandler = new();
            while (true)
            {
                const string animal = "You chose animal quiz";
                const string car = "You chose car quiz";
                const string game = "You chose game quiz";
                const string geography = "You chose geography quiz";
                const string mixed = "You chose mixed category quiz";
                const string invalidInput = "Invalid input, please enter number between 1-5";

                string chosenCategory = InputHandler.Input();
                switch (chosenCategory)
                {
                    case "1":
                        OutputHandler.Write(animal);
                        CreateAnimalQuiz();
                        break;
                    case "2":
                        OutputHandler.Write(car);
                        CreateCarsQuiz();
                        break;
                    case "3":
                        OutputHandler.Write(game);
                        CreateGamesQuiz();
                        break;
                    case "4":
                        OutputHandler.Write(geography);
                        CreateGeographyQuiz();
                        break;
                    case "5":
                        OutputHandler.Write(mixed);
                        CreateMixedQuiz();
                        break;
                    default:
                        OutputHandler.Write(invalidInput);
                        continue;
                }

                break;
            }
        }
    }
}