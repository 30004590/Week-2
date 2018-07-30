using System;


namespace Tasks_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1////////////////////////////////////////////////////////////////////////////////////////////////////

            //Initalising variables
            string name, gender, address;
            int age = 0;

            //Name input
            Console.WriteLine("Please type in Name:");
            name = Console.ReadLine();

            //Age input
            Console.WriteLine("\nPlease type in Age:");
            age = Convert.ToInt32(Console.ReadLine());

            //Gender input
            Console.WriteLine("\nPlease type in Gender:");
            gender = Console.ReadLine();

            //Address input
            Console.WriteLine("\nPlease type in Street Address:");
            address = Console.ReadLine();

            //Outputs
            Console.WriteLine("\nHello {0}.", name);
            Console.WriteLine("Your age is {0}.", age);
            Console.WriteLine("You are a {0}.", gender);
            Console.WriteLine("You live at {0}.", address);
            Console.WriteLine();
            //Task 2////////////////////////////////////////////////////////////////////////////////////////////////////

            //Initalising variables
            float num1 = 0, num2 = 0;

            //Inputs
            Console.WriteLine("Please type in first number:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type in second number:");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Calculations...");

            //Addition output
            float ansAdd = num1 + num2;
            Console.WriteLine("\n{0} + {1} = {2}", num1, num2, ansAdd);

            //Subtraction output
            float ansSub = num1 - num2;
            Console.WriteLine("\n{0} - {1} = {2}", num1, num2, ansSub);

            //Multiplication output
            float ansMul = num1 * num2;
            Console.WriteLine("\n{0} * {1} = {2}", num1, num2, ansMul);

            //Division output
            float ansDiv = num1 / num2;
            Console.WriteLine("\n{0} / {1} = {2}", num1, num2, ansDiv);

            Console.WriteLine();


            //Task 3////////////////////////////////////////////////////////////////////////////////////////////////////

            //initalising variables
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
