using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{        
    //https://projecteuler.net/problem=3
    //What is the largest prime factor of the number 600851475143 ?
    public class Problem3:IProblem
    {
        public String GetSolution()
        {
            long num = 600851475143;
            long i;
            for(i = 3; num>i; i += 2)
            { 
                // number being factored is odd can ignore two, and even numbers
                while(num%i == 0)
                {
                    // if num is a factor of i remove it (will only be factored by prime numbers since we started at the lowest odd prime)
                    num /= i; 
                }
            }
            return i.ToString();
        }
    }
}