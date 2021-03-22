using System;
using System.Collections.Generic;
using System.Linq;
namespace Codility_Lessons.MaximumSliceProblem
{
    public class MaxProfit
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 0;
            var leftMinimum = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                    leftMinimum[i] = A[i];
                else
                {
                    leftMinimum[i] = Math.Min(A[i], leftMinimum[i - 1]);
                }
            }
            int maxProfit = 0;
            for (int i = 1; i < A.Length; i++)
            {
                maxProfit = Math.Max(A[i] - leftMinimum[i - 1], maxProfit);
            }
            return maxProfit;

        }

    }
}
