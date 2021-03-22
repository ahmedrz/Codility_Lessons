using System;
using System.Collections.Generic;

namespace Codility_Lessons.PrimeAndCompositeNumbers
{
    public class Flags
    {
        public int solution(int[] A)
        {
            //one element mean there is no peak
            if (A.Length == 1)
                return 0;
            //first step is to get the peaks
            List<int> peaks = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }
            //if no peeks return 0 flags;
            if (peaks.Count == 0)
            {
                return 0;
            }
            //if one peaks return 1 flag;
            if (peaks.Count == 1)
                return 1;
            int maxK = (int)Math.Floor(Math.Sqrt(A.Length)) + 1;
            maxK = Math.Min(maxK, peaks.Count);

            if (maxK == 1)
                return 1;
            int k = 0;
            for (int i = 1; i <= maxK; i++)
            {
                var lastPeak = peaks[0];
                int count = 1;
                for (int j = 1; j < peaks.Count; j++)
                {
                    var currentPeak = peaks[j];
                    if (currentPeak - lastPeak >= i)
                    {
                        count++;
                        if (count >= i)
                        {
                            k = i;
                            break;
                        }
                        lastPeak = currentPeak;
                    }
                }
            }
            return k;
        }
    }
}
