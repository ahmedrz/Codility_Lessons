namespace Codility_Lessons.EuclideanAlgorithm
{
    public class ChocolatesByNumbers
    {
        public int solution(int N, int M)
        {
            var _gcd = gcd(N, M, 1);
            double _lcm = (double)N * M / _gcd;

            return (int)(_lcm / M);
        }
        private int gcd(int a, int b, int res)
        {
            if (a == b)
                return a * res;
            else if ((a % 2) == 0 && (b % 2) == 0)
            {
                return gcd(a / 2, b / 2, res * 2);
            }
            else if (a % 2 == 0)
            {
                return gcd(a / 2, b, res);
            }
            else if (b % 2 == 0)
            {
                return gcd(a, b / 2, res);
            }
            else if (a > b)
            {
                return gcd(a - b, b, res);
            }
            else
            {
                return gcd(a, b - a, res);
            }
        }
    }
}
