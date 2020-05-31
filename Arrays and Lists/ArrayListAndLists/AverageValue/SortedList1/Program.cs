using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,Person> people = new SortedList<string,Person>();
            people.Add("Marcin",new Person() { Name = "Marcin", Country = Person.CountryEnum.PL, Age = 29 });
            people.Add("Sabine",new Person() { Name = "Sabine", Country = Person.CountryEnum.PL, Age = 25 });
            people.Add("Ann", new Person() { Name = "Ann", Country = Person.CountryEnum.PL, Age = 31 });

            foreach (KeyValuePair<string,Person> person in people)
            {
                Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from {person.Value.Country}");
            }

            Console.ReadKey();
        }
    }
}
