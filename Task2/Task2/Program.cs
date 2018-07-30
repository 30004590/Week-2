using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            float num1 = 0, num2 = 0;

            //inputs
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
            Console.WriteLine("press enter to close program");
            Console.ReadLine();

        }
    }
}
