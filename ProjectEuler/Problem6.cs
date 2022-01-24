using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    // https://projecteuler.net/problem=6
    // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    public class Problem6:IProblem
    {
         public String GetSolution()
         {
            int n = 100;
            long squareOfSumOfNaturalNums = 0;

            IEnumerable<(int naturalNumber, int Square)> squares =
                from i in Enumerable.Range(1, n)
                let b = i * i
                select (i,b);
        
            squareOfSumOfNaturalNums = squares.Select(x => x.naturalNumber).Sum();
            squareOfSumOfNaturalNums *= squareOfSumOfNaturalNums;
            
            return (squareOfSumOfNaturalNums - squares.Select(x => x.Square).Sum()).ToString();
            }
         }

}