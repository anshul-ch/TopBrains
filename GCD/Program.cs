using System;
class Program
{
    static void Main()
    {
        int a = 48;
        int b = 18;
        Console.WriteLine(Gcd(a, b));
    }
    static int Gcd(int a, int b)
    {
        if (b == 0)
            return a;
        return Gcd(b, a % b);
    }
}

