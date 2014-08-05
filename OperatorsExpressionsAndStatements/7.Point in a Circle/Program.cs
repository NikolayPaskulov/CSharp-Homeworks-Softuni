using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Write("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        double s = Math.PI * (2 * 2);

        bool inCirclet = (x * x) + (y * y) <= s;
        Console.WriteLine("These coordinates are inside the circle = " + inCirclet);

    }
}
