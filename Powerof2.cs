using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class Powerof2
    {
        public void Power2()
        {
            Console.WriteLine("Enter the value of n: ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Powers of 2:");
            for (int i = 0; i <= n; i++) 
            {
                int result = (int)Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {result}");
            }
        }
    }
}
