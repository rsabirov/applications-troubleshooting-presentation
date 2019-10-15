using System;
using System.IO;

namespace FileNotFound
{
    class Program
    {
        static void Main()
        {
            try
            {
                LoadDependencies();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }




































        private static void LoadDependencies()
        {
            File.ReadAllText("c:/temp/important-dependency.txt");
        }
    }
}
