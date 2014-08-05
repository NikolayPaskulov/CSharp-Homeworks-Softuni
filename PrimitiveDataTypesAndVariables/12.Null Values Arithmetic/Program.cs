using System;


class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? nullinteger = null;
        double? nulldoub = null;
        Console.WriteLine(nullinteger);
        Console.WriteLine(nulldoub);

        nullinteger += 5;
        Console.WriteLine(nullinteger);

        nulldoub += 3.14;
        Console.WriteLine(nulldoub);
    }
}

