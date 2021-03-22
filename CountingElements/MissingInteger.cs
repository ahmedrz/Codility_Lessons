using System.Linq;

namespace Codility_Lessons.CountingElements
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            if (A.Length == 1)
            {
                if (A[0] <= 0)
                {
                    return 1;
                }
                else if (A[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return A[0] - 1;
                }
            }
            int missingNo = 1;
            int currentNo = 0;
            var sortedList = A.Distinct().Where(item => item > 0).OrderBy(item => item).ToList();
            for (int i = 0; i < sortedList.Count; i++)
            {
                currentNo = sortedList[i];
                if (currentNo == missingNo)
                {
                    missingNo++;
                }
                else
                    return missingNo;
            }
            return missingNo;
        }

    }
}
