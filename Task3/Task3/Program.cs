using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fname, Lname;
            

            //Names input
            Console.WriteLine("Please type in first name:");
            Fname = Console.ReadLine();
            Console.WriteLine("Please type in second name:");
            Lname = Console.ReadLine();

            //Output
            Console.WriteLine("\nHello {0} {1}.", Fname, Lname);
            //Another Method...
            Console.WriteLine("\nHello {0}" + " {1}", Fname, Lname);

            Console.WriteLine();
            Console.WriteLine("press enter to close program");
            Console.ReadLine();

        }
    }
}
