using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {

        static void Main(string[] args)
        {
            DeleteAllfolders(rootPath);
            DeleteAllfiles();
        }


        //a function to delete all the files

        public static void DeleteAllfiles()
        {
            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
        }
        //a function to delete all the folders
        public static void DeleteAllfolders()
        {
            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dirInfo in directory.GetDirectories())
            {
                DeleteAllfolders(dirInfo.FullName);
                dirInfo.Delete();
            }
        }
    }
}
