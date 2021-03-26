using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility_Lessons.SieveOfEratosthenes
{
    public class CountNonDivisible
    {
        public int[] solution(int[] A)
        {

            int[,] noOccurences = new int[(A.Length * 2) + 1, 2];
            for (int i = 0; i < A.Length; i++)
            {
                int number = A[i];
                noOccurences[number, 0]++;
                noOccurences[number, 1] = -1;
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (noOccurences[A[i], 1] != -1)
                    continue;
                noOccurences[A[i], 1] = 0;
                int number = A[i];
                for (int j = 1; j <= Math.Sqrt(number); j++)
                {
                    if (number % j == 0)
                    {
                        if (j * j == number)
                        {
                            noOccurences[number, 1] += noOccurences[j, 0];
                        }
                        else
                        {
                            noOccurences[number, 1] += noOccurences[j, 0];
                            noOccurences[number, 1] += noOccurences[number / j, 0];
                        }
                    }
                }
            }
            int[] result = new int[A.Length];

            int totalCount = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                result[i] = totalCount - noOccurences[A[i], 1];
            }

            return result;

        }
    }
}
