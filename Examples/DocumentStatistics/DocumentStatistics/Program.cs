namespace DocumentStatistics
{
    using System;
    using System.IO;
    using System.Linq;

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
                    var myCounter = new CommonWordCounter(lines);
                    Console.WriteLine("There are " + myCounter.WordDictionary.Count + " unique words in the file " + filePath);

                    var listOfWords = myCounter.WordDictionary.ToList().Select(x => new { Count = x.Value, Word = x.Key }).ToList();
                    var sortedList = listOfWords.OrderByDescending(x => x.Count).ToList();
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

    private class WordCount
    {
        public int Count { get; set; }
        public string Word { get; set; }
    }
}
