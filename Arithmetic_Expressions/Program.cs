using System;
class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        string[] input = expression.Split(' ');
        if (input.Length != 3)
        {
            Console.WriteLine("Error:InvalidExpression");
            return;
        }

        if (!int.TryParse(input[0], out int num1) ||
            !int.TryParse(input[2], out int num2))
        {
            Console.WriteLine("Error:InvalidNumber");
            return;
        }

        string operation = input[1];
        string result = operation switch
        {
            "+" => Add(num1, num2),
            "-" => Subtract(num1, num2),
            "*" => Multiply(num1, num2),
            "/" => Divide(num1, num2),
            _   => "Error:UnknownOperator"
        };
        Console.WriteLine(result);
    }

    static string Add(int a, int b)
    {
        return (a + b).ToString();
    }

    static string Subtract(int a, int b)
    {
        return (a - b).ToString();
    }

    static string Multiply(int a, int b)
    {
        return (a * b).ToString();
    }

    static string Divide(int a, int b)
    {
        if (b == 0)
            return "Error:DivideByZero";

        return (a / b).ToString();
    }
}