class Program
{
    public static void Main(String[] args)
    {
        int[] numbers = { 1, -2, 3, 4, 0, -5, 6 };
        int result = PositiveSum(numbers);
        Console.WriteLine(result);
    }
    public static int PositiveSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                sum += number;
            }
            else if (number == 0)
                break;
        }
        return sum;
    }
}