using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object both = hello + " " + world;
        string bothAsString = (string)both;
        Console.WriteLine(hello);
        Console.WriteLine(world);
        Console.WriteLine(both);
        Console.WriteLine(bothAsString);
    }
}

