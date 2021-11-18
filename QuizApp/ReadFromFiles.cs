using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace QuizApp {
    public class ReadFromFiles {
        
        public static void ReadQuestions(string filePath, List<Questions> listOfQuestions){
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

        public static List<User> RetrieveUser()
        {
            var path = PathManager.GetPath(@"/TextFiles/UserScore.txt");
            List<User> listOfUsers = new();
            using (StreamReader streamReader = new StreamReader(path))
            {

                while (!streamReader.EndOfStream)
                {
                    var userName = streamReader.EndOfStream ? string.Empty : streamReader.ReadLine();
                    long userScore = Convert.ToInt64(streamReader.EndOfStream ? string.Empty : streamReader.ReadLine());

                    listOfUsers.Add(new User(userName, userScore));
                }
            }
            return listOfUsers;
        }
    }
}