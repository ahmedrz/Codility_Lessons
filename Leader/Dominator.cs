namespace Codility_Lessons.Leader
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return -1;
            if (A.Length == 1)
                return 0;
            int stackSize = 0;
            int lastValue = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (stackSize == 0)
                {
                    stackSize++;
                    lastValue = A[i];
                }
                else
                {
                    if (lastValue != A[i])
                        stackSize--;
                    else
                        stackSize++;
                }
            }
            int candidate = -1;
            if (stackSize > 0)
                candidate = lastValue;
            if (candidate == -1)
                return -1;
            int count = 0;
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    count++;
                    index = i;
                }

            }
            if (count > A.Length / 2)
                return index;
            else
                return -1;
        }

    }
}
