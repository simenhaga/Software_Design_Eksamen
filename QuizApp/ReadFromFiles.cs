using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MySqlX.XDevAPI.Common;
using NUnit.Framework;
using Ubiety.Dns.Core;

namespace QuizApp {
    public class ReadFromFiles {
        
        public static void ReadQuestions(string filePath, ref IList listAnimalQuestions){
            //Read file from project path, not from local
            using (StreamReader sr = new StreamReader(filePath))
            {
                string question;
                string optionOne;
                string optionTwo;
                string optionThree;
                while(!sr.EndOfStream) {
                    question = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    optionOne = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    optionTwo = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    optionThree = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    listAnimalQuestions.Add(new Questions(question, optionOne, optionTwo, optionThree));
                } 
            }
        }
        
    }
}