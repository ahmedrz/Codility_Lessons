namespace Codility_Lessons.PrefixSums
{
    public class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            if (A == B)
            {
                if (A % K == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            //
            int currentNo = A;
            while (currentNo % K != 0)
            {
                ++currentNo;
            }
            var leftPart = currentNo / K;
            var rightPart = B / K;
            return rightPart - leftPart + 1;
        }

    }
}
