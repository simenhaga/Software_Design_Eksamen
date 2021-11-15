using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MySqlX.XDevAPI.Common;
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
            string question;
            string optionOne;
            string optionTwo;
            string optionThree;
            
            while(!file.EndOfStream) {
                question = file.EndOfStream ? string.Empty : file.ReadLine();
                optionOne = file.EndOfStream ? string.Empty : file.ReadLine();
                optionTwo = file.EndOfStream ? string.Empty : file.ReadLine();
                optionThree = file.EndOfStream ? string.Empty : file.ReadLine();
                listOfAnimalQuestions.Add(new Questions(question, optionOne, optionTwo, optionThree));
            } 
            file.Close();
            return listOfAnimalQuestions;
        }
        
    }
}