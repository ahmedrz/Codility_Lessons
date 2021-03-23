using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility_Lessons.PrimeAndCompositeNumbers
{
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            List<int> perimeters = new List<int>();
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i * i == N)
                        perimeters.Add(4 * i);
                    else
                    {
                        perimeters.Add(2 * (i + N / i));
                    }
                }
            }
            return perimeters.Min();


        }
    }
}
