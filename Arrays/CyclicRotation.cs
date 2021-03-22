using System.Linq;

namespace Codility_Lessons.Arrays
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {

            var arrayCount = A.Count();
            int[] result = new int[arrayCount];
            if (arrayCount == 1 || arrayCount == K || K == 0 || arrayCount == 0)
            {
                return A;
            }
            //transform k
            if (K > arrayCount)
            {
                K = K % arrayCount;
            }

            var startIndex = arrayCount - K;
            for (int i = 0; i < arrayCount; i++)
            {
                int inputArrayIndex = startIndex + i;
                if (inputArrayIndex >= arrayCount)
                {
                    var difference = inputArrayIndex - arrayCount;
                    inputArrayIndex = difference;
                }
                result[i] = A[inputArrayIndex];
            }
            return result;
        }
    }
}
