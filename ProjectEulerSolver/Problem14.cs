using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerSolver
{
    //https://projecteuler.net/problem=14
    /*


The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.


    */
    public class Problem14 : IProblem
    {
        private Dictionary<long, int> cachedResults = new Dictionary<long, int>() { { 1, 1 } }; // init caches for private funciton and add base case
        public string GetSolution()
        {
            KeyValuePair<long, int> result = cachedResults.First(); ;
            for (int i = 1; i < 1000000; i++)
            {
                CollatzSequence(i);
            }
            foreach (var pair in cachedResults)
            {
                //Console.WriteLine(pair);
                if (result.Value < pair.Value)
                {
                    result = pair;
                }
            }
            return result.Key.ToString();
        }
        public ProblemDescription GetProblemDescription()
        {
            return new ProblemDescription("Longest Collatz sequence", 14, "Which starting number, under one million, produces the longest Collatz chain?");
        }
        private int CollatzSequence(long n)
        {
            int count = 0;//, m = n;
            Queue<int> numbers = new Queue<int>();
            if (cachedResults.TryGetValue(n, out count))
            {
                return count;
            }

            if (n % 2 == 0)
            {
                count = CollatzSequence(n / 2) + 1;
                cachedResults.TryAdd(n, count);
                return count;
            }
            else
            {
                count = CollatzSequence(3 * n + 1) + 1;
                cachedResults.TryAdd(n, count);
                return count;
            }
        }
    }
}