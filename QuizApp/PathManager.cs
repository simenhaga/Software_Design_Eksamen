using System;
using System.IO;
using System.Reflection;

namespace QuizApp {
    public class PathManager {
        public static string GetPath(string filePath) {
            string localPath;
            localPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ??
                                     throw new InvalidOperationException());
            localPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(localPath).FullName).FullName).FullName;
            localPath += filePath;
            return localPath;
        }
    }
}