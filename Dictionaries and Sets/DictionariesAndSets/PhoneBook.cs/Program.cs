using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable phoneBook = new Hashtable()
            {
                {"Marcin Jamro","111-111-1111" },
                {"John Smith", "222-222-2222" }
            };
            //using indexer does not throw an error for duplicate key
            //updates existing key
            phoneBook["Lily smith"] = "333-333-3333";

            try
            {
                phoneBook.Add("Mary Fox", "444-444-4444");
            } catch(ArgumentException)
            {
                Console.WriteLine("The entry already exists");
            }
            Console.WriteLine("Phone Numbers: ");
            if(phoneBook.Count == 0)
            {
                Console.WriteLine("Empty");
            } else
            {
                foreach(DictionaryEntry entry in phoneBook)
                {
                    Console.WriteLine($" - {entry.Key}: {entry.Value}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Search by Name:");
            string name = "Mary Fox";
            if(phoneBook.ContainsKey(name))
            {
                string number = (string)phoneBook[name];
                Console.WriteLine($"Found phone number: {number}");
            } else
            {
                Console.WriteLine("The entry does not exist");
            }
        }
    }
}
