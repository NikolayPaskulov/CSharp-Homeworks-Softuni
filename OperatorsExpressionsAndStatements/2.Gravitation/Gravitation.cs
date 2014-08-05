using System;

class Gravitation
{
    static void Main(string[] args)
    {
        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());

        double weightOnMoon = (weight * 0.17);

        Console.WriteLine("Your weight on moon will be: " + weightOnMoon);
    }
}

