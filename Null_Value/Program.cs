using System;

class Program
{
    static void Main()
    {
        // Sample inputs
        double?[] values1 = { 1.235, null, 2.345, 3.0 };
        double?[] values2 = { null, null };
        double?[] values3 = { };

        PrintAverage(values1);
        PrintAverage(values2);
        PrintAverage(values3);
    }

    static void PrintAverage(double?[] values)
    {
        double? avg = AverageNonNull(values);

        if (avg.HasValue)
            Console.WriteLine($"Average: {avg.Value}");
        else
            Console.WriteLine("Average: null");
    }

    static double? AverageNonNull(double?[] values)
    {
        if (values == null || values.Length == 0)
            return null;

        double sum = 0;
        int count = 0;

        foreach (var v in values)
        {
            if (v.HasValue)
            {
                sum += v.Value;
                count++;
            }
        }

        if (count == 0)
            return null;

        double avg = sum / count;
        return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
    }
}