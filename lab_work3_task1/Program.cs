using System;

public class Parallelogram
{
    public double SideA;
    public double SideB;
    public double Angle;

    public Parallelogram(double sideA, double sideB, double angle)
    {
        SideA = sideA;
        SideB = sideB;
        Angle = angle;
    }

    public double Perimeter()
    {
        return 2 * (SideA + SideB);
    }

    public double Area()
    {
        return SideA * SideB * Math.Sin(Angle * Math.PI / 180);
    }

    public (double, double) Diagonals()
    {
        double diagonal1 = Math.Sqrt(SideA * SideA + SideB * SideB - 2 * SideA * SideB * Math.Cos(Angle * Math.PI / 180));
        double diagonal2 = Math.Sqrt(SideA * SideA + SideB * SideB + 2 * SideA * SideB * Math.Cos(Angle * Math.PI / 180));
        return (diagonal1, diagonal2);
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of side A:");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side B:");
        double sideB = Convert.ToDouble(Console.ReadLine());

        //перевірка валідності сторін
        if (sideA <= 0 || sideB <= 0)
        {
            Console.WriteLine("Sides must be positive numbers.");
            return;
        }


        Console.WriteLine("Enter the angle in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        //перевірка валідності куту
        if (angle <= 0 || angle >= 180)
        {
            Console.WriteLine("Angle must be between 0 and 180 degrees.");
            return;
        }


        Parallelogram parallelogram = new Parallelogram(sideA, sideB, angle);

        Console.WriteLine($"Perimeter: {parallelogram.Perimeter()}");
        Console.WriteLine($"Area: {parallelogram.Area()}");

        var diagonals = parallelogram.Diagonals();
        Console.WriteLine($"Diagonal 1: {diagonals.Item1}");
        Console.WriteLine($"Diagonal 2: {diagonals.Item2}");
    }
}