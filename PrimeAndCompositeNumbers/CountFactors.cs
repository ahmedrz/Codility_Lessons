using System;

namespace Codility_Lessons.PrimeAndCompositeNumbers
{
    public class CountFactors
    {
        public int solution(int N)
        {
            int divisors = 0;
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i * i == N)
                        divisors++;
                    else
                        divisors += 2;
                }
            }
            return divisors;
        }

    }
}
