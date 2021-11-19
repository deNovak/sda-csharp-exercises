using System;

namespace sda_csharp_exercises
{
    class Program
    {
        //Napisz funkcję, która będzie sortowała podaną tablicę liczb wykorzystując algorytm sortowania
        //bąbelkowego.

        public static int[] BubbleSort(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < numberArray.Length - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int deletedNumber = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = deletedNumber;
                    }
                }
            }

            return numberArray;
        }

        static void Main(string[] args)
        {
            int[] numberArray = { 6, 8, 52, 3, 15, 11, 28, 12, 32, 23, 20 };

            int[] sortedNumberArray = BubbleSort(numberArray);

            foreach (int number in sortedNumberArray)
            {
                Console.Write($"{number}, ");
            }
        }
    }
}