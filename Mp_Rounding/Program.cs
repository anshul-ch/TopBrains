using System;

class Program
{
    static void Main()
    {
        // Sample inputs
        Console.WriteLine(CircleArea(0));     // 0.00
        Console.WriteLine(CircleArea(5));     // 78.54
        Console.WriteLine(CircleArea(10.25)); // 330.06
    }

    static double CircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
}