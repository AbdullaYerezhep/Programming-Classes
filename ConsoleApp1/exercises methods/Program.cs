using System;
using Math;

namespace exercises_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-10{MathUtilities.IsPrime(-10)}");
            Console.WriteLine($"1{MathUtilities.IsPrime(1)}");
            Console.WriteLine($"23{MathUtilities.IsPrime(23)}");
            Console.WriteLine($"0{MathUtilities.IsPrime(0)}");
            Console.WriteLine($"8{MathUtilities.IsPrime(8)}");
            Console.WriteLine($"76{MathUtilities.IsPrime(76)}");
            Console.WriteLine($"9{MathUtilities.IsPrime(9)}");
        }
    }
}
