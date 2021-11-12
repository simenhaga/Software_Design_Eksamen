using System;
using static QuizApp.ReadFromFile;

namespace QuizApp {
    class Program {
        public static void Main(string[] args) {
            CreateAnimalQuiz();
            
            Console.WriteLine("Hello! Welcome to our super cool quiz application. \r\n" + 
                              "Please enter your username");

            var userName = Console.ReadLine();

            if (userName == "taken")
            {
                do
                {
                    Console.WriteLine("Username is already taken, please enter another username");
                    userName = Console.ReadLine();

                } while (userName == "taken");
                
                Console.WriteLine("Welcome " + userName + "\r\n" + "Please choose a category");
            }
            else
            {
                Console.WriteLine("Welcome " + userName + "!\r\n" + 
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
                        Console.WriteLine(animal);
                        break;
                    case "2":
                        Console.WriteLine(car);
                        break;
                    case "3":
                        Console.WriteLine(game);
                        break;
                    case "4":
                        Console.WriteLine(geography);
                        break;
                    case "5":
                        Console.WriteLine(mixed);
                        break;
                    default:
                        Console.WriteLine(invalidInput);
                        continue;
                }

                break;
            }
        }
    }
}