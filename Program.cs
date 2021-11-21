using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            Square square = new Square(4);
            Circle circle = new Circle(3);

            figures.Add(square);
            figures.Add(circle);

            double total = 0;
            foreach (Figure f in figures)
            {
                total += f.GetArea();
            }
            Console.WriteLine(total);


        }
    }
}