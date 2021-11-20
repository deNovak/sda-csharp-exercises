using System;

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

            Employee employee = new Employee();
            employee.FirstName = "Jan";
            employee.LastName = "Kowalski";
            employee.YearOfBirth = 1981;
            employee.Salary = 5000;
            employee.WhoAmI();
            Employee employee2 = new Employee("Adam", "Nowak", 2000, 5000);
            employee2.WhoAmI();

        }
    }
}
