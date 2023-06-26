using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class LargestNum
    {
        public void LargestNumber()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!");
                }
                else
                {
                    Console.Write("Number three is the largest!");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("Number two is the largest!");
            }
            else
            {
                Console.Write("Number three is the largest!");
            }
        }
    }
}

