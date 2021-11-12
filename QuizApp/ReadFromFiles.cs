using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace QuizApp {
    public class ReadFromFiles {
        string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
        filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;
        filePath += @"/TextFiles/AnimalQuestions.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        // foreach (string line in lines) {
        //     Console.WriteLine(line);
        // }
             
        string line;
        List listOfAnimalQuestions = new List();

        // Read the file and display it line by line.
        System.IO.StreamReader file = 
                new System.IO.StreamReader(filePath);
            while((line = file.ReadLine()) != null)
        {
            string[] words = line.Split('\n');
            listOfAnimalQuestions.Add(new Questions(Question[0],OptionOne[1],words[2]));
        }

        file.Close();
    }
    }
}