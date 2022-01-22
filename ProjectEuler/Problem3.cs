using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem3:Problem
    {
        //https://projecteuler.net/problem=3
        //What is the largest prime factor of the number 600851475143 ?
        public String getSolution(){
            long num = 600851475143;
            long i;
            for(i = 3; num>i; i += 2){ // number being factored is odd can ignore two, and even numbers
                while(num%i == 0){
                    num /= i;
                }
                i += 2;
            }
            return i.ToString();
        }
    }
}