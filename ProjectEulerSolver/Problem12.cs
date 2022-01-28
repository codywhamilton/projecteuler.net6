using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerSolver
{
    //https://projecteuler.net/problem=12
    //What is the value of the first triangle number to have over five hundred divisors?
    public class Problem12 : IProblem
    {
        public string GetSolution()
        {
            int triangle = 0;
            for(int i = 1; i < int.MaxValue; i++)
            {
                triangle += i; 
                if(GetDivisorCount(triangle) > 500){
                    return triangle.ToString();
                }
            }

            return "";
        }
        public ProblemDescription GetProblemDescription()
        {
            return new ProblemDescription("Highly divisible triangular number", 12, "What is the value of the first triangle number to have over five hundred divisors?");
        }
        private long GetDivisorCount(long number)
        {
            //will not be 1 for this problem but for completness of this function if I reuse the code elsewhere.
            if (number == 1)
                return 1;

            int count = 0;
            int squareRoot = (int) Math.Ceiling(Math.Sqrt(number));
            //if x is a divisor of number then number/x is also a divisor. We only need to find the divisors upto the cealing of square root of the number
            for(int i = 1; i <= squareRoot; i++){
                if(number % i == 0){
                    count++; 
                }
            }
            return count * 2;
        }
        
    }
}