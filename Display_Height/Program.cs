using System;

class Program
{
    static void Main()
    {
        double heightCm = double.Parse(Console.ReadLine());
        string category = GetHeightCategory(heightCm);
        Console.WriteLine(category);
    }

    static string GetHeightCategory(double heightCm)
    {
        if (heightCm < 150)
            return "Short";
        else if (heightCm < 180)
            return "Average";
        else if (heightCm >= 180 && heightCm <= 300)
            return "Tall";
        else
            return "Invalid height";
    }
}