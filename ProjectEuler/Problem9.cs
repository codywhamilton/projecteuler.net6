using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem9 : IProblem
    {
        // https://projecteuler.net/problem=9
        /*

        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a2 + b2 = c2

        For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.
        */
        public string GetSolution()
        {
            //a+b+x = 1000
            //c>333
            //a+b<667
            int a = 1, b = 1, c = 334;
            while (c < 1000)
            {
                while (a + b < 667)
                {
                    if (a + b + c == 1000)
                    {
                        if (a * a + b * b == c * c)
                        {
                            return (a * b * c).ToString();
                        }
                    }
                    a++;
                }
                a = 1;
                b++;
                if (b == 667)
                {
                    b = 1;
                    c++;
                }
            }
            return "";
        }
    }
}