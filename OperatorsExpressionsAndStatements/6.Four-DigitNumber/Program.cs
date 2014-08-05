using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your four digit number: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number % 10;

        int secondDigit = (number / 10) % 10;

        int thirdDigit = (number / 100) % 10;

        int fourthDigit = (number / 1000) % 10;

        int sumOfDigit = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("The sum of digit is: " + sumOfDigit);
        Console.WriteLine("The reversed order is {0}{1}{2}{3}.", firstDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Last digit at first position - {0}{1}{2}{3}.", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("Exchanges the second and the third digits - {0}{1}{2}{3}.", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}

