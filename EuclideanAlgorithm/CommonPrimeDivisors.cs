namespace Codility_Lessons.EuclideanAlgorithm
{
    public class CommonPrimeDivisors
    {
        public int solution(int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (HasSamePrimeDivisors(A[i], B[i]))
                {
                    count++;
                }
            }
            return count;

        }

        private bool HasSamePrimeDivisors(int A, int B)
        {
            //this function is not correct but everything else seems fine
            var _gcd = gcd(A, B, 1);
            while (A > 0)
            {
                var __gcd = gcd(A, _gcd, 1);
                if (__gcd == 1)
                    break;
                A /= __gcd;
            }
            if (A != 1)
                return false;
            while (B > 0)
            {
                var __gcd = gcd(B, _gcd, 1);
                if (__gcd == 1)
                    break;
                B /= __gcd;
            }
            return B == 1;
        }

        private int gcd(int A, int B, int res)
        {
            if (A == B)
            {
                return A * res;
            }
            else if (A % 2 == 0 && B % 2 == 0)
            {
                return gcd(A / 2, B / 2, res * 2);
            }
            else if (A % 2 == 0)
            {
                return gcd(A / 2, B, res);
            }
            else if (B % 2 == 0)
            {
                return gcd(A, B / 2, res);
            }
            else if (A > B)
            {
                return gcd(A - B, B, res);
            }
            else
            {
                return gcd(A, B - A, res);
            }


        }
    }
}
