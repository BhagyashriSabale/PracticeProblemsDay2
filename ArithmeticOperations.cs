using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class ArithmeticOperations
    {
        public void Operations()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an arithmetic operation:");
            Console.WriteLine("\n1. Addition \n2.Substraction \n3.Multiplication \n4.division");
            int choice= Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("The Addition of this 2 numbers is: " +result);
                break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("The Substraction of this 2 numbers is: " + result);
                break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("The Multiplication of this 2 numbers is: " + result);
                break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("The Division of this 2 numbers is: " + result);
                break;
                default:
                    Console.WriteLine("Invalid choice!");
                break;


            }

        }
    }
}
