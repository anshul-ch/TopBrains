using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int initialBalance = int.Parse(input[0]);
        int[] transactions = new int[input.Length - 1];
        for (int i = 1; i < input.Length; i++)
        {
            transactions[i - 1] = int.Parse(input[i]);
        }

        int finalBalance = CalculateFinalBalance(initialBalance, transactions);
        Console.WriteLine(finalBalance);
    }

    static int CalculateFinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                balance += transaction;
            }
            else if (balance + transaction >= 0)
            {
                balance += transaction;
            }
        }

        return balance;
    }
}