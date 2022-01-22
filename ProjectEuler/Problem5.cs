using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem5:Problem
    {
        //https://projecteuler.net/problem=5
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         public String getSolution(){
             //smallest possible will be larger than the product of all primes from 1-20
             //2, 3, 5, 7, 11, 13, 17 and 19.
            //to be evenly divisable by all numbers between 1-20 must be a a number that is a supper set of the Unique Prime Factorization of each numer.
             //16 is 2^4 and 9 is 3^2
             var primes = new List<int> { 2, 2, 2, 2, 3, 3, 5, 7, 11, 13, 17, 19};
             int result = 1;
             foreach(int num in primes){
                 result *= num;
             }
             return result.ToString();
         }
    }
}