using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = true;

            do
            {

                int choice = 0;
                Console.WriteLine("===================================");
                Console.WriteLine("Please select which task to access ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. 2.");

                Console.WriteLine("Enter number here:");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    task1();

                }

                else if (choice == 2)
                {
                    task2();
                }

                else if(choice == 3)
                {
                    task3();
                }

                else if (choice == 4)
                {
                    task4();
                }

                else if (choice == 5)
                {
                    task5();
                }

                else
                {
                    task6();
                }



                Console.WriteLine("\nDo You Want to run another task? Y/N");
                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();



            } while (restart);


        }

        public static void task1()
        {
            int num1 = 0, num2 = 0;


            Console.WriteLine("\nPlease Enter First Number:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Second Number:");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("\n{0} is equal to {1}", num1, num2);

            }
            else if (num1 > num2)
            {
                Console.WriteLine("\n{0} is greater than {1}", num1, num2);

            }
            else
            {
                Console.WriteLine("\n{0} is less than {1}", num1, num2);

            }
            return;

            //{0:0.0}
        }

        public static void task2()
        {
            int myNum = 6, userNum = 0;

            Console.WriteLine("Guess My Number");
            while (myNum != userNum)
            {

                userNum = 0;
                Console.WriteLine("\nEnter Number:");
                userNum = Int32.Parse(Console.ReadLine());

                if (userNum == myNum)
                {
                    Console.WriteLine("Correct, you win");

                }
                else if (userNum > myNum)
                {
                    Console.WriteLine("Sorry that is higher than the number");

                }
                else
                {
                    Console.WriteLine("Sorry that is lower than the number");

                }

            }

            return;

        }

        public static void task3()
        {
            int grade = 0;
            Console.WriteLine("=====Grades=====");
            Console.WriteLine("\nPlease Enter final score:");
            grade = Int32.Parse(Console.ReadLine());



            if (grade > 100)
            {
                Console.WriteLine("Warning {0} is larger than maximum", grade);
            }

            else if (grade < 0)
            {
                Console.WriteLine("Warning {0} is smaller than minimum", grade);
            }

        
            else if (grade >= 90)
            {
                Console.WriteLine("Grade: A+");
            }

            else if (grade >= 80)
            {
                Console.WriteLine("Grade: A");
            }

            else if (grade >= 70)
            {
                Console.WriteLine("Grade: B+");
            }

            else if (grade >= 60)
            {
                Console.WriteLine("Grade: B");
            }

            else if (grade >= 50)
            {
                Console.WriteLine("Grade: C");
            }

            else if (grade >= 40)
            {
                Console.WriteLine("Grade: D");
            }

            else
            {
                Console.WriteLine("Grade: F");
            }
 

        }
        public static void task4()
        {




        }
        public static void task5()
        {




        }
        public static void task6()
        {




        }



    }
}
