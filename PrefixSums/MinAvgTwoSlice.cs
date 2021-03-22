namespace Codility_Lessons.PrefixSums
{
    public class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            int lastPosition = A.Length - 1;
            double minAverage = double.MaxValue;
            int[] preFix = new int[A.Length + 1];
            //fill the prefix
            for (int i = 0; i < preFix.Length; i++)
            {
                if (i == 0)
                {
                    preFix[0] = 0;
                    continue;
                }
                preFix[i] = preFix[i - 1] + A[i - 1];
            }
            //slice of twos
            for (int i = 0; i < preFix.Length - 2; i++)
            {
                var average = (preFix[i + 2] - preFix[i]) / (double)2;
                if (average <= minAverage)
                {
                    if (average < minAverage || i < lastPosition)
                    {
                        lastPosition = i;
                    }
                    minAverage = average;
                }
            }
            for (int i = 0; i < preFix.Length - 3; i++)
            {
                var average = (preFix[i + 3] - preFix[i]) / (double)3;
                if (average <= minAverage)
                {
                    if (average < minAverage || i < lastPosition)
                    {
                        lastPosition = i;
                    }
                    minAverage = average;
                }
            }
            return lastPosition;

        }

    }
}
