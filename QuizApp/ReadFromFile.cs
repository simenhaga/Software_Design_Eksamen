using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace QuizApp {
    public class ReadFromFile {

        public static void CreateAnimalQuiz() {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException(), @"TextFiles/AnimalQuestions.txt");;
            List<string> lines = File.ReadAllLines(filePath).ToList();
            //List<string> oneLine = File.Read(filePath).ToList();

            // foreach (string line in lines) {
            //     Console.WriteLine(line);
            // }
            
            
        }

    }
}