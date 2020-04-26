using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Porter Merrell";
            var location = " Rexburg";

            Console.WriteLine(name + location);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

            /* Date */
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToShortDateString() }");

            /* Christmas */
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            Console.WriteLine($"Christmas is on: {christmasDay.ToShortTimeString() }");

            var timeSpan = christmasDay - currentDate;
            var numberOfDaysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"The number of days utnil Christmas: {numberOfDaysUntilChristmas}");

        }
    }
}
