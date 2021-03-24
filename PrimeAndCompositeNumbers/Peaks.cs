using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Lessons.PrimeAndCompositeNumbers
{
    public class Peaks
    {
        public int solution(int[] A)
        {
            //when the length is one there is no peaks
            if (A.Length == 1)
                return 0;
            int result = 0;
            //storing the peak's indexes
            List<int> peaks = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }
            //getting the available number of groups by finding the divisors
            for (int i = 1; i <= A.Length; i++)
            {
                if (A.Length % i != 0)
                    continue;
                int groupSize = A.Length / i;
                //when the groupsize is two or one it is impossible to have peaks in all of them
                if (groupSize == 1 || groupSize == 2)
                    continue;
                int groups = i;
                int groupsHasPeaks = 0;
                for (int j = 0; j < peaks.Count; j++)
                {
                    if (peaks[j] / groupSize == groupsHasPeaks)
                        groupsHasPeaks++;
                }
                if (groupsHasPeaks == groups)
                    result = groups;
            }

            return result;
        }
    }
}
