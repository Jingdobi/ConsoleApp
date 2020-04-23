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
        }
    }
}
