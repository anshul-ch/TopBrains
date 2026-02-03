using System;
using System.Globalization;

interface IArea
{
    double GetArea();
}

abstract class Shape : IArea
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private readonly double width;
    private readonly double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Triangle : Shape
{
    private readonly double @base;
    private readonly double height;

    public Triangle(double @base, double height)
    {
        this.@base = @base;
        this.height = height;
    }

    public override double GetArea()
    {
        return 0.5 * @base * height;
    }
}

class Program
{
    static void Main()
    {
        string[] shapes =
        {
            "C 3",
            "R 4 5",
            "T 10 2",
            "X invalid"
        };

        double totalArea = ComputeTotalArea(shapes);
        Console.WriteLine($"Total Area: {totalArea}");
    }

    static double ComputeTotalArea(string[] shapes)
    {
        if (shapes == null || shapes.Length == 0)
            return 0.0;

        double total = 0.0;

        foreach (var line in shapes)
        {
            Shape shape = ParseShape(line);
            if (shape != null)
            {
                total += shape.GetArea();
            }
        }

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    static Shape ParseShape(string line)
    {
        if (string.IsNullOrWhiteSpace(line))
            return null;

        string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        try
        {
            switch (parts[0])
            {
                case "C" when parts.Length == 2:
                    return new Circle(Parse(parts[1]));

                case "R" when parts.Length == 3:
                    return new Rectangle(Parse(parts[1]), Parse(parts[2]));

                case "T" when parts.Length == 3:
                    return new Triangle(Parse(parts[1]), Parse(parts[2]));
            }
        }
        catch
        {
            // Ignore malformed input
        }

        return null;
    }

    static double Parse(string value)
    {
        return double.Parse(value, CultureInfo.InvariantCulture);
    }
}
