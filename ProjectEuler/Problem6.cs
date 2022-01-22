using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem6:Problem
    {
        // https://projecteuler.net/problem=6
        // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         public String getSolution(){
            int n = 100;
            long SquareOfSumOfNaturalNums = 0;

            IEnumerable<int> squares =
                from i in Enumerable.Range(1, n)
                let b = i * i
                select b;

            IEnumerable<int> naturalNumbers =
                from i in Enumerable.Range(1, n)
                select i;
        
            SquareOfSumOfNaturalNums = naturalNumbers.Sum();
            SquareOfSumOfNaturalNums *= SquareOfSumOfNaturalNums;
            
            return (SquareOfSumOfNaturalNums - squares.Sum()).ToString();
            }
         }

}