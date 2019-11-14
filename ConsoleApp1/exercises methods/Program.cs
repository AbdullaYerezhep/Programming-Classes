using System;
using Maths;

namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Maths.AreCoprime(8,9));
            //Console.WriteLine(Maths.AreCoprime(8,10));
            var solution1 = MathUtilities.SolveQuadratic(1, 5, 6);
            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }
    }
}
