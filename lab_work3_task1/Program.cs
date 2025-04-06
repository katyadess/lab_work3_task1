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