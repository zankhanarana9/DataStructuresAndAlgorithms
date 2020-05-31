using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, choice;
            string name;

            Console.Write("Enter initial size of the table");
            int size = Convert.ToInt32(Console.ReadLine());

            HashTable table = new HashTable(size);

            while (true)
            {
                Console.WriteLine("1. Insert a record");
                Console.WriteLine("2. Search a record");
                Console.WriteLine("3. Delete a record");
                Console.WriteLine("4. Display Table");
                Console.WriteLine("5. Break");

                Console.WriteLine("Enter a  choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter  Student ID");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student Name");
                        name = Console.ReadLine();

                        StudentRecord rec = new StudentRecord(id, name);
                        table.Insert(rec);
                        break;

                    case 2:
                        Console.WriteLine("Enter a  key to be searcehd");
                        id = Convert.ToInt32(Console.ReadLine());
                        rec = table.SearchStudent(id);
                        if(rec ==null)
                        {
                            Console.WriteLine("Key not found");
                        } else
                        {
                            Console.WriteLine(rec.ToString());
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter a  key to be deleted");
                        id = Convert.ToInt32(Console.ReadLine());
                        table.Delete(id);
                        break;

                    case 4:
                        table.DisplayTable();
                        break;

                    case 5:
                    default:
                        break;
                }
            }
        }
    }
}
