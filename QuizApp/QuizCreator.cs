using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using Ubiety.Dns.Core;

namespace QuizApp {
    public class ReadFromFile {

        public static void CreateAnimalQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/AnimalQuestions.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

             foreach (string line in lines) {
                 Console.WriteLine(line);
             }
        }

        public static void CreateCarsQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());;
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/CarsQuestions.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }
        
        public static void CreateGamesQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());;
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/GamesQuestions.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }
        
        public static void CreateGeographyQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());;
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/GeographyQuestions.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }

    }
}