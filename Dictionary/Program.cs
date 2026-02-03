using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Input
        var salaries = new Dictionary<int, int>
        {
            { 1, 20000 },
            { 4, 40000 },
            { 5, 15000 }
        };

        int[] ids = { 1, 4, 5 };

        int totalSalary = GetTotalSalary(ids, salaries);
        Console.WriteLine(totalSalary);
    }

    static int GetTotalSalary(int[] ids, Dictionary<int, int> salaryByEmployeeId)
    {
        if (ids == null || salaryByEmployeeId == null)
            return 0;

        int total = 0;

        foreach (int id in ids)
        {
            if (salaryByEmployeeId.TryGetValue(id, out int salary))
            {
                total += salary;
            }
        }

        return total;
    }
}