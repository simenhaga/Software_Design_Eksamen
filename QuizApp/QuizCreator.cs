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
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(filePath, ref list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadKey();
        }

        public static void CreateCarsQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/CarsQuestions.txt";
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(filePath, ref list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadKey();
        }
        
        public static void CreateGamesQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/GamesQuestions.txt";
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(filePath, ref list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadKey();
        }
        
        public static void CreateGeographyQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/GeographyQuestions.txt";
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(filePath, ref list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadKey();
        }
        public static void CreateMixedQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/MixedQuestions.txt";
            IList list = new ArrayList();
            ReadFromFiles.ReadQuestions(filePath, ref list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadKey();
        }
        

    }
}