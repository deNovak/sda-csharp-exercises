using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintText("Adam", "Maurycy", "Jaworski", false, 35, "Radomska", 32, 7, "Warszawa");
            Console.WriteLine();
            PrintText("Jan", "Banach", false, 10, "Morska", 19, "Wrocław");
            Console.WriteLine();
            PrintText("Anna", "Stawska", true, 66, "Batorego", 434, 11, "Gdynia");
            Console.WriteLine();
            PrintText("Jolanta", "Leokadia", "Zagórska", true, 49, "Kokosowa", 17, "Siedlce");
        }

        static void PrintText(string firstName, string lastname, bool isFemale, int age, string streetName, int streetNumber, int apartmentNumber, string cityName)
        {
            PrintText(firstName, "", lastname, isFemale, age, streetName, streetNumber, apartmentNumber, cityName);
        }

        static void PrintText(string firstName, string secondName, string lastname, bool isFemale, int age, string streetName, int streetNumber, string cityName)
        {
            PrintText(firstName, secondName, lastname, isFemale, age, streetName, streetNumber, 0, cityName);
        }

        static void PrintText(string firstName, string lastname, bool isFemale, int age, string streetName, int streetNumber, string cityName)
        {
            PrintText(firstName, "", lastname, isFemale, age, streetName, streetNumber, 0, cityName);
        }

        static void PrintText(string firstName, string secondName, string lastname, bool isFemale, int age, string streetName, int streetNumber, int apartmentNumber, string cityName)
        {
            Console.WriteLine($"{firstName} {secondName} {lastname}");
            Console.WriteLine($"ul. {streetName} {streetNumber} / {(apartmentNumber == 0 ? "" : apartmentNumber)} {cityName}");

            if (age >= 18)
            {
                if (isFemale)
                    Console.WriteLine("Szanowna Pani");
                else
                    Console.WriteLine("Szanowny Panie");
            }
            else
            {
                if (isFemale)
                    Console.WriteLine("Droga Użytkowniczko");
                else
                    Console.WriteLine("Drogi Użytkowniku");
            }

            if (age < 18)
                Console.WriteLine($"Zapraszamy Cię serdecznie na otwarcie naszego sklepu!");
            else
            {
                if (isFemale)
                    Console.WriteLine($"Zapraszamy Panią serdecznie na otwarcie naszego sklepu!");
                else
                    Console.WriteLine($"Zapraszamy Pana serdecznie na otwarcie naszego sklepu!");
            }

            if (age < 18)
                Console.WriteLine($"Powitamy Cię kubkiem gorącej czekolady.");
            else
            {
                if (isFemale)
                    Console.WriteLine($"Powitamy Panią kieliszkiem szampana.");
                else
                    Console.WriteLine($"Powitamy Pana kieliszkiem szampana.");
            }

            if (age > 60)
                Console.WriteLine("I zapraszamy do gry w bingo");

            if (age < 18)
                Console.WriteLine("Do zobaczenia");
            else if (age > 60)
            {
                Console.WriteLine("Z wyrazami szacunku");
            }
            else
            {
                if (isFemale)
                    Console.WriteLine($"Czekamy na Panią.");
                else
                    Console.WriteLine($"Czekamy na Pana.");
            }

        }
    }
}