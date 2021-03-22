using System.Linq;

namespace Codility_Lessons.Sorting
{
    public class NumberOfDiscIntersections
    {
        public int solution(int[] A)
        {
            var openList = new long[A.Length];

            var closeList = new long[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                openList[i] = i - (long)A[i];
                closeList[i] = i + (long)A[i];

            }
            openList = openList.OrderBy(item => item).ToArray();
            closeList = closeList.OrderBy(item => item).ToArray();
            int openDisks = 0;
            long intersections = 0;
            int closeListIndex = 0;
            for (int i = 0; i < openList.Length; i++)
            {
                if (openList[i] <= closeList[closeListIndex])
                {
                    intersections += openDisks;
                    openDisks++;
                }
                else
                {
                    closeListIndex++;
                    openDisks--;
                    i--;
                }
            }
            if (intersections > 10000000)
                return -1;
            else
                return (int)intersections;

        }

    }
}
