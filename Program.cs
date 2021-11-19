using System;

namespace sda_csharp_exercises
{
    class Program
    {

        public static void PrintTriangle(int width, char character)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine("");
            }
            for (int i = width - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine("");

        static public void ArithmeticSequence(int length, int firstNumber, int difference)
        {
            int sum = firstNumber;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{sum} ");
                sum += difference;

            }
        }

        static void Main(string[] args)
        {

            Console.Write("Podaj szerokość podstawy: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj znak do budowy trójkąta: ");
            char character = Convert.ToChar(Console.ReadLine());

            PrintTriangle(width, character);


            //Napisz funkcję tworzącą ciąg arytmetyczny o podanych: długości, pierwszym elemencie, różnicy ciągu.
            // 4 0 3
            // 0 3 6 9

            Console.Write("Podaj długość ciągu: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj pierwszy element ciągu: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj różnicę: ");
            int difference = Convert.ToInt32(Console.ReadLine());

            ArithmeticSequence(length, firstNumber, difference);

        }
    }
}