using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class NumbersEqualorNot
    {
        public void num()
        {
            Console.WriteLine("Enter the first num: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num: ");
            int n2=Convert.ToInt32(Console.ReadLine());
            if(n1==n2)
            {
                Console.WriteLine("The two integers are equal.");
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
            }
        }
    }
}
