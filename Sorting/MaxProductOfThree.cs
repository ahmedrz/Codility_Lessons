using System.Linq;

namespace Codility_Lessons.Sorting
{
    public class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            var sorted = A.OrderBy(item => item).ToArray();
            var lastTriplet = sorted[A.Length - 1] * sorted[A.Length - 2] * sorted[A.Length - 3];
            var firstTriplet = sorted[0] * sorted[1] * sorted[A.Length - 1];
            if (lastTriplet > firstTriplet)
            { return lastTriplet; }
            else
            {
                return firstTriplet;
            }

        }

    }
}
