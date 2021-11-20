using System;

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

        }
    }
}
