using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace QuizApp {
    public class ReadFromFile {

        public static void CreateAnimalQuiz() {
            string filePath = "/Users/simenhaga/Desktop/HK/2. året/Software Design/SoftwareDesign-Eksamen/QuizApp/TextFiles/AnimalQuestions.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }

    }
}