using System;

class Program
{
    static void Main()
    {
        object[] values =
        {
            10,
            "hello",
            true,
            null,
            25,
            3.14,
            5
        };

        int sum = SumIntegers(values);
        Console.WriteLine($"Sum: {sum}");
    }

    static int SumIntegers(object[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        int sum = 0;

        foreach (var item in values)
        {
            if (item is int x)
            {
                sum += x;
            }
        }

        return sum;
    }
}