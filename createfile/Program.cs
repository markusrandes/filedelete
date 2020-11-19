using System;
using System.IO;

namespace createfile
{
    class Program
    {
        private static string fileName;

        static void Main(string[] args)
        {
            //CreatnewFile();
            Console.WriteLine("enter the file name:");
            string userInput = Console.ReadLine();
            CreateUserFile(userInput);
        }


        public static void CreatnewFile()
        {
            string rootPath = @"C:\Users\opilane\samples\playerOne";
            string filename = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }
    
    public static void CreateUserFile(string fileName)
    { 
    string rootPath = @"C:\Users\opilane\samples\playerTwo";
    File.Create(Path.Combine(rootPath, fileName));
    }
    }
    public static void CreateFileWithExtentsion(string fileName)
    {
         
    }
}