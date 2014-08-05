using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y ");
        double y = double.Parse(Console.ReadLine());

        bool inCiclet = ((x - 1) * (x - 1)) * ((y - 1) * (y - 1)) <= (1.5 * 1.5);
        bool outOfRectangle = (x < -1 && x > 5) && (y < -1 && y > 1);

        if (inCiclet == true && outOfRectangle == true)
        {
            Console.WriteLine("YES!!!");
        }
        else
        {
            Console.WriteLine("NO :(!!!");
        }
    }
}

