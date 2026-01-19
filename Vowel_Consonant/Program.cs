using System;

class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        string step1Result = RemoveCommonConsonants(word1, word2);
        string finalResult = RemoveConsecutiveDuplicates(step1Result);

        Console.WriteLine(finalResult);
    }

    static string RemoveCommonConsonants(string word1, string word2)
    {
        string result = "";
        foreach (char c in word1)
        {
            char lowerChar = char.ToLower(c);
            if (IsVowel(lowerChar))
            {
                result += c;
            }
            else
            {
                if (!word2.ToLower().Contains(lowerChar))
                {
                    result += c;
                }
            }
        }
        return result;
    }
    static string RemoveConsecutiveDuplicates(string word)
    {
        if (word.Length == 0)
            return word;
        string result = "";
        result += word[0];
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] != word[i - 1])
            {
                result += word[i];
            }
        }
        return result;
    }
    static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}