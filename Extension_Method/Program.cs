using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] items =
        {
            "1:Rahul",
            "2:Ayaan",
            "1:Imran",
            "3:Priya",
            "2:Zaid",
            "4:Fatima",
            "3:Neha"
        };

        string[] result = GetDistinctNames(items);

        foreach (string name in result)
        {
            Console.WriteLine(name);
        }
    }

    static string[] GetDistinctNames(string[] items)
    {
        if (items == null || items.Length == 0)
            return new string[0];

        List<string> names = new List<string>();
        HashSet<string> seenIds = new HashSet<string>();

        foreach (string item in items)
        {
            string[] parts = item.Split(':');
            if (parts.Length != 2)
                continue;

            string id = parts[0];
            string name = parts[1];
            if (!seenIds.Contains(id))
            {
                seenIds.Add(id);
                names.Add(name);
            }
        }

        return names.ToArray();
    }
}