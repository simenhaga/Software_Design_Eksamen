using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using QuizApp;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReadFromFile() {
            var filepath = PathManager.GetPath(@"/TextFiles/TestFile.txt");
            StreamReader sr = new StreamReader(filepath);
            string firstLine = sr.ReadLine();
            Assert.AreEqual("Who's your daddy?", firstLine);
        }

        [Test]
        public void ShouldListQuestions() {
            var filepath = PathManager.GetPath(@"/TextFiles/TestQuestion.txt");
            List<Questions> testList = new List<Questions>();
            ReadFromFiles.ReadQuestions(filepath, testList);
            
            StreamReader sr = new StreamReader(filepath);
            string firstLine = sr.ReadLine();

            Assert.AreEqual("What is your name?", firstLine);
        }

        [Test]
        public void ShouldValidateUser() {
        // pause
        }
    }
}