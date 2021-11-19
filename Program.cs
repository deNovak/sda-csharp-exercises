using System;

namespace sda_csharp_exercises
{
    class Program
    {
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