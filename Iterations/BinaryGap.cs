using System;
using System.Linq;

namespace Codility_Lessons.Iterations
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            if (N < 1 || N > int.MaxValue)
            {
                return 0;
            }
            string binaryRepresentation = Convert.ToString(N, 2);
            string[] array = binaryRepresentation.TrimEnd('0').Split('1');
            if (array.Length == 0)
            {
                return 0;
            }
            var largestGap = array.ToList().Select(item => item.Length).Max();
            return largestGap;

        }
    }
}
