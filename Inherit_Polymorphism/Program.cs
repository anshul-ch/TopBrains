using System;
using System.Globalization;

abstract class Employee
{
    public abstract decimal GetPay();
}

class HourlyEmployee : Employee
{
    private readonly decimal rate;
    private readonly decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal GetPay()
    {
        return rate * hours;
    }
}

class SalariedEmployee : Employee
{
    private readonly decimal monthlySalary;

    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    public override decimal GetPay()
    {
        return monthlySalary;
    }
}

class CommissionEmployee : Employee
{
    private readonly decimal commission;
    private readonly decimal baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal GetPay()
    {
        return baseSalary + commission;
    }
}

class Program
{
    static void Main()
    {
        string[] employees =
        {
            "H 20 40",
            "S 3000",
            "C 500 2000",
            "X invalid"
        };

        decimal totalPay = ComputeTotalPayroll(employees);
        Console.WriteLine($"Total Payroll: {totalPay}");
    }

    static decimal ComputeTotalPayroll(string[] employees)
    {
        if (employees == null || employees.Length == 0)
            return 0m;

        decimal total = 0m;

        foreach (var line in employees)
        {
            Employee employee = ParseEmployee(line);
            if (employee != null)
            {
                total += employee.GetPay();
            }
        }

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    static Employee ParseEmployee(string line)
    {
        if (string.IsNullOrWhiteSpace(line))
            return null;

        string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        try
        {
            switch (parts[0])
            {
                case "H" when parts.Length == 3:
                    return new HourlyEmployee(
                        decimal.Parse(parts[1], CultureInfo.InvariantCulture),
                        decimal.Parse(parts[2], CultureInfo.InvariantCulture));

                case "S" when parts.Length == 2:
                    return new SalariedEmployee(
                        decimal.Parse(parts[1], CultureInfo.InvariantCulture));

                case "C" when parts.Length == 3:
                    return new CommissionEmployee(
                        decimal.Parse(parts[1], CultureInfo.InvariantCulture),
                        decimal.Parse(parts[2], CultureInfo.InvariantCulture));
            }
        }
        catch
        {
            // Ignore malformed records
        }

        return null;
    }
}
