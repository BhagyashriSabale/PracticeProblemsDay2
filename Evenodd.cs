﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class Evenodd
    {
        public void EvenOdd() 
        {
            Console.WriteLine("Enter the number: ");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("The given number is Even.");
            }
            else
            {
                Console.WriteLine("the given number is odd.");
            }
        }
    }
}
