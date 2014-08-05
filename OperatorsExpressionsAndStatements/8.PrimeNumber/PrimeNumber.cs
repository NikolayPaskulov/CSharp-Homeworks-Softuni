using System;

class PrimeNumberCheck
{
    static void isPrime(int Num)
    {
        if (Num == 1) Console.WriteLine("Is not prime.");
        if (Num == 2) Console.WriteLine("Is prime.");

        for (int i = 3; i < Num; i += 2)
        {
            if (Num % 2 == 0)
            {
                Console.WriteLine("Is not prime.");
                break;
            }
            if (Num % i == 0)
            {
                Console.WriteLine("Is not prime.");
                break;
            }
            else
            {
                Console.WriteLine("Is prime.");
                break;
            }
        }
    }
    static void Main()
    {
        int Num = int.Parse(Console.ReadLine());

        PrimeNumberCheck.isPrime(Num);
    }
}

