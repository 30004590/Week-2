using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //initalising variables
            string name, gender, address;
            int age = 0;

            //name input
            Console.WriteLine("Please type in Name:");
            name = Console.ReadLine();

            //age input
            Console.WriteLine("\nPlease type in Age:");
            age = Convert.ToInt32(Console.ReadLine());

            //gender input
            Console.WriteLine("\nPlease type in Gender:");
            gender = Console.ReadLine();

            //address input
            Console.WriteLine("\nPlease type in Street Address:");
            address = Console.ReadLine();

            //outputs
            Console.WriteLine("\nHello {0}.", name);
            Console.WriteLine("Your age is {0}.", age);
            Console.WriteLine("You are a {0}.", gender);
            Console.WriteLine("You live at {0}.", address);
           





            Console.WriteLine();
            Console.WriteLine("press enter to close program");
            Console.ReadLine();
        }
    }
}
