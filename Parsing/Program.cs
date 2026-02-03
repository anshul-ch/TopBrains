using System;

class Program
{
    static void Main()
    {
        // Sample inputs
        string[] tokens1 = { "10", "20", "abc", "30" };
        string[] tokens2 = { "100", "2147483647", "2147483648", "-5" };
        string[] tokens3 = { };

        PrintSum(tokens1);
        PrintSum(tokens2);
        PrintSum(tokens3);
    }

    static void PrintSum(string[] tokens)
    {
        int sum = SumValidIntegers(tokens);
        Console.WriteLine($"Sum: {sum}");
    }

    static int SumValidIntegers(string[] tokens)
    {
        if (tokens == null || tokens.Length == 0)
            return 0;

        int sum = 0;

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int value))
            {
                sum += value;
            }
        }

        return sum;
    }
}