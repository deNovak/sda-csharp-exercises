using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję do obliczania potęgi o zadanych podstawie i wykładniku.
            //*zabezpiecz swój program tak, aby dla ujemnego wykładnika wyświetlał odpowiedni komunikat.
            Console.WriteLine("Wpisz postawę postęgowania");
            int basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz wykładnik postęgowania");
            int tonumber = Convert.ToInt32(Console.ReadLine());
            if (tonumber < 0)
            {
                Console.WriteLine("Wykładnk <0");
            }
            else
            {
                Console.WriteLine($"Wynik = {Powertox(basenumber, tonumber)}");
            }
        }
        static int Powertox(int Basenumber, int tonumber)
        {
            int value = Basenumber;
            for (int i = 1; i < tonumber; i++)
            {
                value *= Basenumber;
            }
            return value;
        }

    }
}