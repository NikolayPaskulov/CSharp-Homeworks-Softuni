using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double esp = 0.000001;

        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("First number is: " + a);
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Second number is: " + b);

        bool compare = Math.Abs(a - b) < esp;
        Console.WriteLine(compare);
    }
}

