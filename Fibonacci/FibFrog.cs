using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Lessons.Fibonacci
{
    public class FibFrog
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 1;
            int N = A.Length;
            List<int> fib = new List<int>();
            fib.Add(0);
            fib.Add(1);
            for (int i = 2; i <= 26; i++)
            {
                fib.Add(0);
                fib[i] = fib[i - 1] + fib[i - 2];
                if (fib[i] > N + 1)
                {
                    fib.RemoveAt(i);
                    break;
                }
                else if (fib[i] == N + 1)
                    return 1;
            }
            var list = A.ToList();
            list.Insert(0, 1);
            list.Add(1);
            Dictionary<int, int> memo = new Dictionary<int, int>();
            var paths = solve(0, fib.ToArray(), list.ToArray(), memo);
            return paths;
        }
        private int solve(int position, int[] fib, int[] A, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(position))
                return memo[position];
            int N = A.Length;
            if (position == N - 1) return 0;
            if (position > N - 1) return -1;
            int minPath = -1;
            for (int i = 2; i < fib.Length; i++)
            {
                int step = fib[i];
                if (position + step >= N || A[position + step] != 1)
                    continue;
                var nextSteps = solve(position + step, fib, A, memo);
                if (nextSteps != -1)
                {
                    if (minPath == -1 || nextSteps + 1 < minPath)
                        minPath = nextSteps + 1;
                }
            }
            memo[position] = minPath;
            return minPath;
        }
    }
}
