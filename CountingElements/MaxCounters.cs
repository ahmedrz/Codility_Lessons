namespace Codility_Lessons.CountingElements
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            int[] result = new int[N];

            int arrayCount = A.Length;
            int currentMax = 0;
            int lastMax = 0;
            for (int i = 0; i < arrayCount; i++)
            {
                int counterIndex = A[i] - 1;
                if (counterIndex == N)
                {
                    lastMax = currentMax;
                }
                else
                {
                    if (result[counterIndex] < lastMax)
                    {
                        result[counterIndex] = lastMax + 1;
                    }
                    else
                    {
                        ++result[counterIndex];
                    }
                    if (result[counterIndex] > currentMax)
                    {
                        currentMax = result[counterIndex];
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < lastMax)
                {
                    result[i] = lastMax;
                }
            }
            return result;
        }

    }
}
