using System;

namespace Codility_Lessons.MaximumSliceProblem
{
    public class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            int[] left = new int[A.Length];
            int[] right = new int[A.Length];

            for (int i = 1; i < A.Length - 1; i++)
            {
                left[i] = Math.Max(left[i - 1] + A[i], 0);
            }
            for (int i = A.Length - 2; i > 0; i--)
            {
                right[i] = Math.Max(right[i + 1] + A[i], 0);
            }
            int maxDoubleSum = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (left[i - 1] + right[i + 1] > maxDoubleSum)
                    maxDoubleSum = left[i - 1] + right[i + 1];

            }
            return maxDoubleSum;

        }

    }
}
