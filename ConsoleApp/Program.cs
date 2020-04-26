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

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am currently in {location}");


            /* Date */
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToShortDateString() }");

            /* Christmas */
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            Console.WriteLine($"Christmas is on: {christmasDay.ToShortDateString() }");

            var timeSpan = christmasDay - currentDate;
            var numberOfDaysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"The number of days utnil Christmas: {numberOfDaysUntilChristmas}");



            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Input the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Input the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to escape: ");
            Console.ReadKey();

        }
    }
}
