using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {

        static void Main(string[] args)
        {
            Cat cat = new Cat("Mruczek");
            cat.MakeSound();
            Dog dog = new Dog("Burek");
            dog.MakeSound();

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (Animal a in animals)
            {
                a.MakeSound();
                if (a is Cat)
                {
                    Console.WriteLine("It's a cat");
                }
                else if (a is Dog)
                {
                    Console.WriteLine("It's a dog");
                }
                else
                {
                    Console.WriteLine("We don't know!");
                }
            }
        }
    }
}
