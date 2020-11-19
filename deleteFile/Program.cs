using System;
using System.IO;

namespace deleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void FileDelete()
        {
            string rootPath = @"C:\Users\opilane\samples\playerTwo";
            string fileName = "ball.txt";

            if(File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
            }else
            {
                Console.WriteLine("file not found.");
            }




        }
    }
}
