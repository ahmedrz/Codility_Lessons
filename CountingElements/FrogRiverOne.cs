using System.Collections.Generic;
using System.Linq;

namespace Codility_Lessons.CountingElements
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            Dictionary<int, int> positions = new Dictionary<int, int>();
            int arrayCount = A.Count();
            for (int i = 0; i < arrayCount; i++)
            {
                int position = A[i];
                int outValue;
                bool alreadyEntered = positions.TryGetValue(position, out outValue);
                if (!alreadyEntered)
                {
                    positions.Add(position, i);
                }
                if (positions.Count == X)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
