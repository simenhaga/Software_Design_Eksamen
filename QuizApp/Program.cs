﻿using System;
using static QuizApp.ReadFromFile;

namespace QuizApp {
    class Program {
        public static void Main(string[] args)
        {
            OutputHandler outputHandler = new();
           

            outputHandler.Write("Hello! Welcome to our super cool quiz application. \r\n" + 
                              "Please enter your username");

            var userName = Console.ReadLine();

            if (userName == "taken")
            {
                do
                {
                    outputHandler.Write("Username is already taken, please enter another username");
                    userName = Console.ReadLine();

                } while (userName == "taken");
                
                outputHandler.Write("Welcome " + userName + "\r\n" + "Please choose a category");
            }
            else
            {
                outputHandler.Write("Welcome " + userName + "!\r\n" + 
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

                string chosenCategory = Console.ReadLine();
                switch (chosenCategory)
                {
                    case "1":
                        outputHandler.Write(animal);
                        CreateAnimalQuiz();
                        break;
                    case "2":
                        outputHandler.Write(car);
                        CreateCarsQuiz();
                        break;
                    case "3":
                        outputHandler.Write(game);
                        CreateGamesQuiz();
                        break;
                    case "4":
                        outputHandler.Write(geography);
                        CreateGeographyQuiz();
                        break;
                    case "5":
                        outputHandler.Write(mixed);
                        ReadFromFiles.ReadQuestions();
                        break;
                    default:
                        outputHandler.Write(invalidInput);
                        continue;
                }

                break;
            }
        }
    }
}