using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerSolver
{
    //https://projecteuler.net/problem=4
    //Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4 :IProblem
    {
        const int _LowerBound = 100, _UpperBound = 999;
         public String GetSolution()
         {
             string reversedPossible;
             int result =0, possibleResult = 0;
             for(int i = _UpperBound; i>=_LowerBound; i--)
             {
                 for(int j = _UpperBound; j>=_LowerBound; j--)
                 {
                    possibleResult = i*j;
                    if(possibleResult < result) { // we have already found a larger palindrome for i*j short cercuite the inner loop.
                        j=_LowerBound;
                    }
                    else
                    {
                        reversedPossible = new string(possibleResult.ToString().ToCharArray().Reverse().ToArray());
                        if(possibleResult.ToString().Equals(reversedPossible))
                        {
                            result = i*j; // must be larger than current result from outer if, and is a palindrome
                        }
                     }
                 }
             }
             return result.ToString();
         }
    }
}