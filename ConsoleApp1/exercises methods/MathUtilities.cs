using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public static class MathUtilities
    {
        public static bool IsPrime(int number)

            public static int Gcd(int a, int b)
            {
            while (a != b)
                {
                if ( a > b)
                    a -= b;
                else
                    b -= a;
            
                }
                 return a; 
            }
            public static bool AreCoprime(int a, int b)
            {
               return Gcd(a,b) == 1;
                
            }
    }
}
