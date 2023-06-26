using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class Factorial
    {
        public void Fact()
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for(int i=1; i<=n; i++) 
            { 
            
                factorial *= i;
               
            }

            Console.WriteLine($"{n} factorial = {factorial}");
        }
    }
}
