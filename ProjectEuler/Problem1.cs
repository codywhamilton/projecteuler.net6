using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=1
    //Find the sum of all the multiples of 3 or 5 below 1000. 
    public class Problem1 :Problem
    {
        public String getSolution(){
            int result = 0;
            for(int i=0;i<1000;i++){
                if(i%3 == 0 || i%5 == 0)
                    result += i;
            }
            return result.ToString();
        }
    }
}