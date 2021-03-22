using System.Linq;

namespace Codility_Lessons.TimeComplexity
{
    public class PermMissingElement
    {
        public int solution(int[] A)
        {
            int arrayCount = A.Count();
            if (arrayCount == 0)
            {
                return 1;
            }
            var sortedList = A.OrderBy(item => item).ToList();
            var lastNo = sortedList.Last();
            if (lastNo != arrayCount + 1)
            {
                return arrayCount + 1;
            }

            int currentNo = 1;
            for (int i = 0; i < arrayCount; i++)
            {
                if (sortedList[i] > currentNo)
                {
                    return currentNo;
                }
                currentNo++;
            }
            return currentNo;
        }
    }
}
