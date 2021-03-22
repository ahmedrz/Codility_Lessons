using System;

namespace Codility_Lessons.MaximumSliceProblem
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            int currentSum = 0;
            int globalSum = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                currentSum = Math.Max(A[i], A[i] + currentSum);
                globalSum = Math.Max(globalSum, currentSum);
            }
            return globalSum;
        }

    }
}
