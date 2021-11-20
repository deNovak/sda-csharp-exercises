using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void PrintHello(Person person)
        {
            if (person.IsAdult())
            {
                Console.WriteLine("Welcoe to liquor store");
            }
            else
            {
                Console.WriteLine("Welcome to toy store");
            }
        }
        static void Main(string[] args)
        {
            //Metoda 1//
            //Person person = new Person();
            //person.WhoAmI();
            //person.FirstName = "Jan";
            //person.LastName = "Kowalski";
            //person.YearOfBirth = 1981;
            //Console.WriteLine(person.IsAdult());

            //Metoda 2//
            //Person person = new Person()
            //{
            //    FirstName = "Jan",
            //    LastName = "Kowalski",
            //    YearOfBirth = 1981
            //};
            //person.WhoAmI();
            //Console.WriteLine(person.IsAdult());

            //Employee employee = new Employee();
            //employee.FirstName = "Jan";
            //employee.LastName = "Kowalski";
            //employee.YearOfBirth = 1981;
            //employee.Salary = 5000;
            //employee.WhoAmI();
            //Employee employee2 = new Employee("Adam", "Nowak", 2000, 5000);
            //employee2.WhoAmI();

            //Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);
            //Console.WriteLine(employee.Salary);
            //Person person = new Employee("Adam", "Nowak", 2000, 6000);
            ////Console.WriteLine(person.Salary);
            //Employee employee2 = (Employee)person;
            //Console.WriteLine(employee2.Salary);

            Person person = new Person("Jan", "Kowalski", 1981);
            Employee employee = new Employee("Adam", "Nowak", 2000, 5000);
            Person person2 = new Employee("Joanna", "Kowalska", 1982, 6000);
            Person person3 = new Person("Joanna", "Nowak", 2015);
            //Employee employee2 = (Employee)person2;
            //Employee employee2 = person2 as Employee;
            

            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(employee);
            people.Add(person2);
            people.Add(person3);

            foreach (Person p in people)
            {
                if (p is Employee e)
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                    Console.WriteLine($"Salary = {e.Salary}");
                }
                else if (p is Person)
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");
                }
                else
                {
                    Console.WriteLine("No idea !?");
                }

                PrintHello(p);
            }

        }
    }
}
