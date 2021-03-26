namespace Codility_Lessons.SieveOfEratosthenes
{
    public class CountSermiPrimes
    {
        public int[] solution(int N, int[] P, int[] Q)
        {
            int[,] sieve = new int[N + 1, 2];
            for (int i = 2; i < N; i++)
            {
                if (sieve[i, 0] == 0)
                {
                    if ((uint)i * i > int.MaxValue)
                        continue;
                    int k = i * i;
                    while (k <= N)
                    {
                        sieve[k, 0] = i;
                        k += i;
                    }
                }
            }
            int[] result = new int[P.Length];
            for (int i = 1; i <= N; i++)
            {
                int x = i;
                int primeFactors = 0;
                while (sieve[x, 0] > 0)
                {
                    primeFactors++;
                    x = x / sieve[x, 0];
                }
                primeFactors++;
                //primeFactors = 2 means it is sermiprime
                if (primeFactors == 2)
                {
                    sieve[i, 1] = sieve[i - 1, 1] + 1;
                }
                else
                {
                    sieve[i, 1] = sieve[i - 1, 1];
                }
            }
            for (int i = 0; i < P.Length; i++)
            {
                result[i] = sieve[Q[i], 1] - sieve[P[i] - 1, 1];

            }

            return result;

        }
    }
}
