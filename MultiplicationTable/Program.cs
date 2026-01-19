using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upto = int.Parse(Console.ReadLine());
        int[] result = GetRowMultiplication(n, upto);
        Console.WriteLine("["+ String.Join(",", result)+"]");

    }
    
    public static int[] GetRowMultiplication(int num, int upto)
    {
        if (upto <= 0)
            return Array.Empty<int>();

        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = num * i;
        }
        return row;
    }
}