using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = "log.txt";
        string outputPath = "error.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains("ERROR"))
                    writer.WriteLine(line);
            }
        }
    }
}