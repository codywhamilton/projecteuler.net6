using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerSolver
{
    //https://projecteuler.net/problem=1
    //Find the sum of all the multiples of 3 or 5 below 1000. 
    public class Problem1 : IProblem
    {
        public String GetSolution()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            return result.ToString();
        }
        public ProblemDescription GetProblemDescription()
        {
            return new ProblemDescription("Multiples of 3 or 5", 1, "Find the sum of all the multiples of 3 or 5 below 1000.");
        }
    }
}