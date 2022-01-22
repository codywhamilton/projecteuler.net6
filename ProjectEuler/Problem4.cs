using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=4
    //Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4 :Problem
    {
         public String getSolution(){
             string reversedPossible;
             int result =0, possibleResult = 0;
             for(int i = 999; i>=100; i--){
                 for(int j = 999; j>=100; j--){
                    possibleResult = i*j;
                    if(possibleResult < result) { // we have already found a larger palindrome for i*j short cercuite the inner loop.
                        j=100;
                    }
                    else{
                        reversedPossible = new string(possibleResult.ToString().ToCharArray().Reverse().ToArray());
                        if(possibleResult.ToString().Equals(reversedPossible)){ 
                            result = i*j; // must be larger than current result from outer if, and is a palindrome
                        }
                     }
                 }
             }
             return result.ToString();
         }
    }
}