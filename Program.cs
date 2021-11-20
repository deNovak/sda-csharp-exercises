using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
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
            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(employee);
            people.Add(person2);

            foreach (Person p in people)
            {
                if (p.GetType() == typeof(Person))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");
                }
                else if (p.GetType() == typeof(Employee))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                    Employee e = (Employee)p;
                    Console.WriteLine($"Salary = {e.Salary}");
                }
                else
                {
                    Console.WriteLine("No idea !?");
                }
            }

        }
    }
}
