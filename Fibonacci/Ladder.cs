using System;
using System.Linq;

namespace Codility_Lessons.Fibonacci
{
    public class Ladder
    {
        public int[] solution(int[] A, int[] B)
        {
            //maximum L from the question 
            int L = 30;
            int max = A.Max();
            int[] fib = new int[max + 2];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= max + 1; i++)
            {
                int value = (int)(fib[i - 1] + fib[i - 2] % Math.Pow(2, L));
                fib[i] = value;
            }
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                int N = A[i];
                int P = B[i];
                result[i] = (int)(fib[N + 1] % Math.Pow(2, P));
            }
            return result;
        }
    }
}
