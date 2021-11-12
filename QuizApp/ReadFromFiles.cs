using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Ubiety.Dns.Core;

namespace QuizApp {
    public class ReadFromFiles {
        
        public static List<Questions> ReadQuestions(){
            //Read file from project path, not from local
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
            filePath += @"/TextFiles/AnimalQuestions.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            //Creates new list of animal questions
            string line;
            List<Questions> listOfAnimalQuestions = new List<Questions>();

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(filePath);
                while((line = file.ReadLine()) != null) {
                    string[] element = line.Split('\n');
                    listOfAnimalQuestions.Add(new Questions(element[0], element[1],element[2], element[3]));
                }
                file.Close();
            return listOfAnimalQuestions;
        }
    }
}