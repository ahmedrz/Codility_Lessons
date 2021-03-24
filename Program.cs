using Codility_Lessons.PrimeAndCompositeNumbers;
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

            Peaks peaks = new Peaks();
            peaks.solution(new int[]
            {
                 1,
                 2,
                 3,
                 4,
                 3,
                 4,
                 1,
                 2,
                 3,
                 4,
                 6,
                 2
            });
        }
    }
}
