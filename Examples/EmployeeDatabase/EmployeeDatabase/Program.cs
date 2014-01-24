using System.IO;

namespace Examples.EmployeeDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            // We assume that we're passed a file path
            if (args.Length == 1)
            {
                var path = args[0];
                if (File.Exists(path))
                {
                    var lines = File.ReadAllText(path);
                    var myDb = new TextFileBasedEmployeeDatabase(lines);
                }
            }
        }
    }
}
