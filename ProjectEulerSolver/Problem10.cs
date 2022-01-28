using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerSolver
{
    public class Problem10 : IProblem
    {
        //https://projecteuler.net/problem=10
        //Find the sum of all the primes below two million.
        public string GetSolution()
        {
            List<int> list = GeneratePrimes(2000000);
            long result = 0;
            foreach (int i in list)
            {
                result += i;
            }
            return result.ToString();
        }
        
        public ProblemDescription GetProblemDescription()
        {
            return new ProblemDescription("Summation of primes", 10, "Find the sum of all the primes below two million.");
        }
        public List<int> GeneratePrimes(int n)
        {
            var r = from i in Enumerable.Range(2, n - 1).AsParallel()
                    where Enumerable.Range(1, (int)Math.Sqrt(i)).All(j => j == 1 || i % j != 0)
                    select i;
            return r.ToList();
        }

    }
}