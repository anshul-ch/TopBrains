using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(FormatTime(125)); // 2:05
        Console.WriteLine(FormatTime(60));  // 1:00
        Console.WriteLine(FormatTime(9));   // 0:09
    }

    static string FormatTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return $"{minutes}:{seconds:D2}";
    }
}