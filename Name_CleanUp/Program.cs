using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        string input = " llapppptop bag ";
        string output = CleanInventoryName(input);
        Console.WriteLine(output);
    }

    static string CleanInventoryName(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        input = input.Trim();

        StringBuilder sb = new StringBuilder();
        char prev = '\0';

        foreach (char c in input)
        {
            if (c != prev)
                sb.Append(c);
            prev = c;
        }

        string cleaned = sb.ToString();
        cleaned = string.Join(" ", cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries));

        TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
        return textInfo.ToTitleCase(cleaned.ToLower());
    }
}