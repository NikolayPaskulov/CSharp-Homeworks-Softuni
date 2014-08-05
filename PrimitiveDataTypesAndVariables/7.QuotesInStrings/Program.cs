using System;

class QuotesInStrings
{
    static void Main(string[] args)
    {
        string firstQuotes = "The \"use\" of quotations causes difficulties.";
        string secondQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstQuotes);
        Console.WriteLine(secondQuotes);
    }
}

