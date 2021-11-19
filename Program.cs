using System;
using System.Linq;

namespace sda_csharp_exercises
{
    class Program
    {
        /*
	    * Dla podanej tablicy liczb naturalnych wypisz tylko niepowtarzające się liczby.
	    Przykład:
	    int[] numbers = {2,5,1,2,5};
	    Wynik:
	    2 5 1
	    Podpowiedź:
	    zauważ, że w tablicy będą tylko liczby naturalne, czyli >= 0. Duplikat możesz więc nadpisać
	    dowolną liczbą ujemną.
	    */
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 1, 2, 5, 6, 8, 5, 5 };
            WriteAllElementsOnce(numbers);
        }

        static void WriteAllElementsOnce(int[] numbers)
        {
            int[] temp = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!temp.Contains(numbers[i]))
                    temp[i] = numbers[i];
                else
                    temp[i] = -1;
            }

            foreach (int item in temp)
            {
                if (item != -1)
                    Console.WriteLine(item);
            }
        }
    }
}