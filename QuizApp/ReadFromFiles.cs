using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace QuizApp {
    public class ReadFromFiles {
        
        public static void ReadQuestions(string filePath, ref IList listOfQuestions){
            //Read file from project path, not from local
            using (StreamReader sr = new StreamReader(filePath))
            {
                while(!sr.EndOfStream) {
                    var question = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    var optionOne = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    var optionTwo = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    var optionThree = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    var correctAnswer = sr.EndOfStream ? string.Empty : sr.ReadLine();
                    listOfQuestions.Add(new Questions(question, optionOne, optionTwo, optionThree, correctAnswer));
                } 
            }
        }

        public static string ReadAnswer(ref IList listOfQuestions)
        {
            var ca = 
            return ca;
        }
        
    }
}