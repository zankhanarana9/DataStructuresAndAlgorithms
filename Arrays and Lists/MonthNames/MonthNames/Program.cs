using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MonthNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = new string[12];
            for(int month = 1; month <= 12; month++)
            {
                DateTime FirstDateTime = new DateTime(DateTime.Now.Year, month, 1);
                string name = FirstDateTime.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                Months[month - 1] = name;
            }

            foreach(string month in Months)
            {
                Console.WriteLine($"--> {month}");
            }

            Console.ReadKey();
        }
    }
}
