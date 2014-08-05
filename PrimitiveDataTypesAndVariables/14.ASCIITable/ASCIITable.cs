using System;
using System.Text;

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }
}
