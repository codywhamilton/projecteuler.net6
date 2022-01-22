using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    // https://projecteuler.net/problem=2
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    public class Problem2:Problem
    {
        public String getSolution(){
            int num1 = 1, num2 = 1, fib = 1, sum = 0;
            while(fib < 4000000){
                if(fib%2==0){
                    sum += fib;
                }
                fib = num1 + num2;
                num2 = num1;
                num1 = fib;
            }
            return sum.ToString();
        }
    }
}