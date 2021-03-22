using System.Linq;

namespace Codility_Lessons.Sorting
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
            { return 0; }
            int result = 1;
            var sortedList = A.OrderBy(item => item).ToArray();
            for (int i = 1; i < sortedList.Length; i++)
            {
                if (sortedList[i] != sortedList[i - 1])
                {
                    result++;
                }
            }
            return result;
        }

    }
}
