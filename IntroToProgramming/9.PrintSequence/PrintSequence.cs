﻿using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 1)
            {
                int j = -i;
                Console.WriteLine(j);
            }
            else
                Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}

