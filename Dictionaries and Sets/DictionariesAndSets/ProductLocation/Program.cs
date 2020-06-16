using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> products = new Dictionary<string, string>()
            {
                { "5900000000000" , "A1"},
                {"590111111111", "B5" },
                {"590333333333","C9" }
            };
            products["590222222222"] = "D7";
            try
            {
                products.Add("590444444444", "A3");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entry already exists");
            }
            Console.WriteLine("All products: ");
            if(products.Count == 0)
            {
                Console.WriteLine("Empty");
            } else
            {
                foreach(KeyValuePair<string,string> pair in products)
                {
                    Console.WriteLine($" - {pair.Key}: {pair.Value}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Search by Barcode: " );
            string barcode = "590111111111";
            if(products.TryGetValue(barcode,out string product))
            {
                Console.WriteLine($"Product found: {product}");
            } else
            {
                Console.WriteLine("The product does not exist");
            }
        }
    }
}
