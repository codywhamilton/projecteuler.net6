using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=7
    //What is the 10 001st prime number?
    public class Problem7 : Problem
    {
        public string getSolution(){
            
            //used prime linq query found at
            //https://stackoverflow.com/questions/1042902/most-elegant-way-to-generate-prime-numbers   @RameshVel answer
            var NoOfPrimes= 10001;
            var GeneratedPrime = Enumerable.Range(1, int.MaxValue)
            .Where(x =>
                {
                    return (x==1)? false:
                            !Enumerable.Range(1, (int)Math.Sqrt(x))
                            .Any(z => (x % z == 0 && x != z && z != 1));
                }).Select(no => no).TakeWhile((val, idx) => idx <= NoOfPrimes-1).ToList();
            return GeneratedPrime[10000].ToString();
        }
    }
}