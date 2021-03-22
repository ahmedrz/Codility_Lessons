namespace Codility_Lessons.PrefixSums
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            int[] prefix = new int[A.Length + 1];
            for (int i = 0; i < prefix.Length; i++)
            {
                if (i == 0)
                {
                    prefix[0] = 0;
                    continue;
                }
                prefix[i] = prefix[i - 1] + A[i - 1];

            }
            long result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    result += prefix[prefix.Length - 1] - prefix[i + 1];
                }
            }
            return result > 1000000000 ? -1 : (int)result;
        }

    }
}
