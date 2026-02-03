using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello world";

        Dictionary<char, int> counts = CountCharacters(input);

        foreach (var count in counts)
        {
            Console.WriteLine($"'{count.Key}': {count.Value}");
        }
    }

    static Dictionary<char, int> CountCharacters(string input)
    {
        var result = new Dictionary<char, int>();

        if (string.IsNullOrEmpty(input))
            return result;

        foreach (char c in input)
        {
            if (result.ContainsKey(c))
                result[c]++;
            else
                result[c] = 1;
        }

        return result;
    }
}