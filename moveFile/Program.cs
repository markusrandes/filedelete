using System;
using System.IO;

namespace moveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static void MoveFile()
        {
            string sourceDirectory = @"C:\Users\opilane\samples\playerOne";
            string DestinationPath = @"C:\Users\opilane\samples\playerTwo";
            string fileName = "ball.txt";
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(DestinationPath, fileName));

        }
    }
}
