using System;

class Program
{
    static void Main()
    {
        // Sample inputs
        Console.WriteLine(FeetToCentimeters(0));    // 0.00
        Console.WriteLine(FeetToCentimeters(5));    // 152.40
        Console.WriteLine(FeetToCentimeters(123));  // 3749.04
    }

    static double FeetToCentimeters(int feet)
    {
        const double CmPerFoot = 30.48;

        double centimeters = feet * CmPerFoot;
        return Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);
    }
}