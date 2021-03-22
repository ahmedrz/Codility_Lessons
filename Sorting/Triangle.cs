using System.Linq;

namespace Codility_Lessons.Sorting
{
    public class Triangle
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
                return 0;
            var sortedList = A.OrderBy(item => item).ToArray();
            for (int i = 0; i < A.Length - 2; i++)
            {
                long first = sortedList[i];
                long second = sortedList[i + 1];
                long third = sortedList[i + 2];

                if (first + second > third)
                {
                    if (second + third > first && first + third > second)
                        return 1;
                }
            }
            return 0;
        }

    }
}
