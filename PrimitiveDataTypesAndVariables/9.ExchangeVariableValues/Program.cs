using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c = a;
        Console.WriteLine(a + "\n" + b);

        a = b;
        b = c;

        Console.WriteLine("Exchange 'a' value:" + a);
        Console.WriteLine("Exchange 'b' value:" + b);
    }
}

