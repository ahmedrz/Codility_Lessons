using Codility_Lessons.EuclideanAlgorithm;
using Codility_Lessons.Fibonacci;
using Codility_Lessons.PrimeAndCompositeNumbers;
using Codility_Lessons.SieveOfEratosthenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flags flags = new Flags();
            //var result = flags.solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 });

            //MinPerimeterRectangle per = new MinPerimeterRectangle();
            //var result = per.solution(30);
            //var result1 = per.solution(1);

            //Peaks peaks = new Peaks();
            //peaks.solution(new int[]
            //{
            //     1,
            //     2,
            //     3,
            //     4,
            //     3,
            //     4,
            //     1,
            //     2,
            //     3,
            //     4,
            //     6,
            //     2
            //});
            //CountNonDivisible countNonDivisible = new CountNonDivisible();
            ////countNonDivisible.solution(new int[] { 3, 1, 2, 3, 6 });
            //CountSermiPrimes countSermiPrimes = new CountSermiPrimes();
            //countSermiPrimes.solution(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 });
            //ChocolatesByNumbers chocolate = new ChocolatesByNumbers();
            //var result = chocolate.solution(10, 4);
            //var result1 = chocolate.solution(947853, 4453);
            //CommonPrimeDivisors commonPrimeDivisors = new CommonPrimeDivisors();
            //var result = commonPrimeDivisors.solution(new int[] { 15, 10, 3 }, new int[] { 75, 30, 5 });
            FibFrog fibFrog = new FibFrog();
            //fibFrog.solution(new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 });
            fibFrog.solution(new int[] { 1 });


        }
    }
}
