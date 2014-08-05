using System;

class AgeAfterTenYers
{
    static void Main()
    {
        DateTime birthdate = new DateTime(1991, 7, 3);
        Console.WriteLine("My birthday is: " + birthdate);
        int currentAge = 22;
        Console.WriteLine("My current age is: "+ currentAge);
        Console.WriteLine("After 10 years I'll be: "+ (currentAge+10));
    }
}

