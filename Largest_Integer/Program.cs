using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        if (!int.TryParse(input[0], out int num1) ||
            !int.TryParse(input[1], out int num2) ||
            !int.TryParse(input[2], out int num3))
        {
            Console.WriteLine("Error:InvalidNumber");
            return;
        }
        int largest = GetLargest(num1, num2, num3);
        Console.WriteLine(largest);
    }

    public static int GetLargest(int num1, int num2, int num3)
    {
        int largest = num1;
        if(num2 > num3 && num2 > num1)
        {
            largest = num2;
        }
        else if(num3 > num1 && num3 > num2)
        {
            largest = num3;
        }
        return largest;
    }
}