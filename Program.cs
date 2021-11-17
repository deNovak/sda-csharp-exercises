using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)

            //E01
            //Napisz metodę, która będzie wyświetlała prosty cennik danego produktu.
            //W zależności od ceny produktu oraz liczby linii, którą ktoś sobie życzy widzieć wydrukuj cennik w
            //postaci:
            //Liczba sztuk: 1 łączna cena: 5zł
            //Liczba sztuk: 2 łączna cena: 10zł
            //Liczba sztuk: 3 łączna cena: 15zł
        {
            Console.Write("Podaj liczbę produktów: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj Cenę produktów: ");
            int price = Convert.ToInt32(Console.ReadLine());

            BucketPrice(number, price);
        }
        public static void BucketPrice(int number, int price)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Liczba pruduktów {i} łączna cena {price * i}zł");
            }
        }
    }
}
