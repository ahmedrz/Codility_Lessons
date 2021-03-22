using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility_Lessons.TimeComplexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var differences = new List<int>();
            int totalSum = A.Sum();
            int currentSum = 0;
            var arrayCount = A.Count();
            if (arrayCount == 2)
            {
                return Math.Abs(A[0] - A[1]);
            }
            for (int i = 1; i < arrayCount; i++)
            {
                currentSum += A[i - 1];
                differences.Add(Math.Abs(currentSum - (totalSum - currentSum)));

            }
            return differences.Min();

        }
    }
}
