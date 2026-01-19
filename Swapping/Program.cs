using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        
        // Using REF
        SwapUsingRef(ref num1, ref num2);
        Console.WriteLine("After swap using ref:");
        Console.WriteLine($"a = {num1}, b = {num2}");
        Console.WriteLine();

        //  Using out

        Console.WriteLine("Before swap using out:");
        Console.WriteLine($"x = {num1}, y = {num2}");

        SwapUsingOut(num1, num2, out num1, out num2);

        Console.WriteLine("After swap using out:");
        Console.WriteLine($"x = {num1}, y = {num2}");
    }

    // Method 1: Swap using ref 
    static void SwapUsingRef(ref int p, ref int q)
    {
        p = p + q;
        q = p - q;
        p = p - q;
    }

    // Method 2: Swap using out 
    static void SwapUsingOut(int p, int q, out int x, out int y)
    {
        x = q;
        y = p;
    }
}