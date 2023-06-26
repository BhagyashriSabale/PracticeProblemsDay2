using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class SumofSquares
    {
        public void Squares()
        {
            Console.WriteLine("Enter the value of n: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                int square = i * i;
                sum += square;
            }
            Console.WriteLine($"The sum of squares of {n} numbers is: {sum}");
        }
    }
}
