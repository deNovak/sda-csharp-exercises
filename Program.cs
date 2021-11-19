using System;
using System.Linq;

namespace sda_csharp_exercises
{
    class Program
    {


        static string L33tCipher(string text)
        {
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] txt = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                txt[i] = text[i];
                for (int j = 0; j < 5; j++)
                {
                    if (txt[i] == naturalLetters[j])
                        txt[i] = leetLetters[j];
                }
            }
            return string.Join("", txt);
        }
        static string L33tDecipher(string text)
        {
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] txt = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                txt[i] = text[i];
                for (int j = 0; j < 5; j++)
                {
                    if (txt[i] == leetLetters[j])
                        txt[i] = naturalLetters[j];
                }
            }
            return string.Join("", txt);
        }
        static void Main(string[] args)
        {
            string text = "Stare dobre hakowanie";
            Console.WriteLine(text);
            Console.WriteLine($"Po zmianie: {L33tCipher(text)}");
            Console.WriteLine($"Po zmianie: {L33tDecipher(text)}");

        }
    }
}