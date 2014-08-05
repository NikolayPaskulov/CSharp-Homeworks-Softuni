using System;


class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("The area of trapezoid is: " + area);
    }
}

