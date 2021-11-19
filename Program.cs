using System;

namespace sda_csharp_exercises
{
    //Napisz funkcję, która będzie wyliczała wartość funkcji silnia dla argumentu podanego przez użytkownika.
    class Program
    {

        static long Strong(int number)
        {
            if (number < 2)
                return 1;
            else
                return number * Strong(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = Convert.ToInt32(Console.ReadLine());
            long result = Strong(number);
            Console.WriteLine(result);

        }
    }
}