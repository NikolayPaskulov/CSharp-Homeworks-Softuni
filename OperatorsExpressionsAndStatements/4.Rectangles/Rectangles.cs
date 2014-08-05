using System;

class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double b = double.Parse(Console.ReadLine());

            double perimeter = (2 * a) + (2 * b);
            double area = a * b;
            Console.WriteLine("Perimeter of rectangle is: " + perimeter);
            Console.WriteLine("Area of rectangle is: " + area);

            bool dataError = (a == 0) || (b == 0);

            if (dataError = true)
            {
                Console.WriteLine("Wrong data!!!");
            }


        }
    }

