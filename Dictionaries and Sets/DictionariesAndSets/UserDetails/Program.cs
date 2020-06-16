using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
            {
                { 100, new Employee () {FirstName= "Marcin", LastName = "Jamro", PhoneNumber = "000-000-000"} },
                { 200, new Employee () {FirstName= "Mary", LastName = "fox", PhoneNumber = "111-111-111"} },
                { 300, new Employee () {FirstName= "John", LastName = "Smith", PhoneNumber = "222-222-222"} }
            };

            bool isCorrect = true;
            do
            {
                Console.WriteLine("Enter the employee identifier");
                string idString = Console.ReadLine();
                isCorrect = int.TryParse(idString, out int id);
                if(isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if(employees.TryGetValue(id,out Employee employee))
                    {
                        Console.WriteLine($"FirstName {employee.FirstName} ");
                    } else
                    {
                        Console.WriteLine("The employee with given identifier does not exist");
                    }
                }
            } while (isCorrect);
        }
    }
}
