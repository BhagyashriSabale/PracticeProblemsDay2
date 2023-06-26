using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class SumofnaturalNumbers
    {
        public void sumofFirst5NaturalNumbers()
        {
            int n = 5;
            int i = 0;
            int sum = 0;
            while(i <= n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum of first 5 natural numbers: " +sum);
            
        }
    }
}
