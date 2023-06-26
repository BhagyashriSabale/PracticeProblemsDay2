using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay2
{
    internal class VotingAge3
    {
        public void AgeVote()
        {
            Console.WriteLine("Enter the age of Candidate: ");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("the candidate is eligible for voting.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for voting.");
            }
        }
    }
}
