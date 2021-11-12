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
            string _filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());;
            _filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName).FullName;
            _filePath += @"/TextFiles/AnimalQuestions.txt";
            List<string> lines = File.ReadAllLines(_filePath).ToList();

             foreach (string line in lines) {
                 Console.WriteLine(line);
             }
            
            
        }

    }
}