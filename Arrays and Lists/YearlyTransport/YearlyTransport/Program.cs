using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearlyTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;
            TransportEnum[][] transport = new TransportEnum[12][];
            for(int month=1;month<=12; month++)
            {
                int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month);
                transport[month - 1] = new TransportEnum[daysCount];
                for(int day=1;day <= daysCount; day++)
                {
                    int randomType = random.Next(transportTypesCount);
                    transport[month - 1][day - 1] = (TransportEnum)randomType;
                }
            }
            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length)+ 12;
            for(int month = 1; month <= 12; month++)
            {
                Console.Write($"{monthNames[month-1]}:".PadRight(monthNamesPart));
                for(int day = 1; day <= transport[month -1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = transport[month - 1][day - 1].GetColor();
                    Console.Write(transport[month - 1][day - 1].GetChar());
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static string[] GetMonthNames()
        {
            string[] Months = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                DateTime FirstDateTime = new DateTime(DateTime.Now.Year, month, 1);
                string name = FirstDateTime.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                Months[month - 1] = name;
            }
            return Months;
        }
    }
}
