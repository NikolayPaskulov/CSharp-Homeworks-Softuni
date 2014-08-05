using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool divided = (number % 5 == 0) && (number % 7 == 0);

        Console.WriteLine("The number is divided by 7 and 5: " + divided);


    }
}

