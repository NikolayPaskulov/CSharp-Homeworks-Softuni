using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        int number1 = 3;
        int number2 = 2;
        int number3 = -2;
        int number4 = -1;
        int number5 = 0;

        if (number1 % 2 == 0)
        {
            Console.WriteLine("Number is Even: " + number1);
        }
        else
        {
            Console.WriteLine("Number is Odd: " + number1);
        }
    }
}

