using System.Linq;

namespace Codility_Lessons.Arrays
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            if (A.Count() == 1)
            {
                return A[0];
            }
            var test = A.GroupBy(item => item).Select(group => new { group.Key, Count = group.Count() }).ToList();
            var oddEntry = test.Where(groupItem => groupItem.Count % 2 != 0).FirstOrDefault();
            return oddEntry.Key;

        }
    }
}
