namespace DocumentStatistics
{
    using System;
    using System.IO;

    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var filePath = args[0];

                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllText(filePath);
                    var myCounter = new WordCounter(lines);
                    Console.WriteLine("There are " + myCounter.Words + " words in the file " + filePath);
                }
                else
                {
                    Console.WriteLine("File does not exist at path " + filePath);
                }
            }
            else
            {
                Console.WriteLine("Not enough arguments, or too many.");
            }
        }
    }
}
