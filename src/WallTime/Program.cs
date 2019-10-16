using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WallTime
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please specify folder path and regex");
                return;
            }
            var path = args[0];
            var regex = new Regex(args[1], RegexOptions.Compiled);

            var resultFiles = FindInFiles(path, regex);
            DisplayResults(resultFiles);
        }

        private static void DisplayResults(List<string> resultFiles)
        {
            foreach (var resultFile in resultFiles)
                Console.WriteLine(resultFile);
        }

        private static List<string> FindInFiles(string path, Regex regex)
        {
            var resultFiles = new List<string>();
            foreach (var directoryPath in Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    foreach (var filePath in Directory.GetFiles(directoryPath, "*.*"))
                    {
                        if (regex.IsMatch(File.ReadAllText(filePath)))
                        {
                            resultFiles.Add(filePath);
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error reading directory {directoryPath}: {e.Message}");
                }
            }

            return resultFiles;
        }
    }
}
