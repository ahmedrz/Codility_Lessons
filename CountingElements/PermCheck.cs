using System.Linq;

namespace Codility_Lessons.CountingElements
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            if (A.Length == 1)
            {
                if (A[0] == 1)
                {
                    return 1;
                }
                else
                    return 0;
            }
            var sortedList = A.Distinct().OrderBy(item => item).ToList();
            if (sortedList.Count != A.Length)
            {
                return 0;
            }
            int currentNo = 1;
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (sortedList[i] != currentNo)
                {
                    return 0;
                }
                else
                {
                    currentNo++;
                }
            }
            return 1;
        }

    }
}
