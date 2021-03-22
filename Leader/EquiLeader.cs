namespace Codility_Lessons.Leader
{
    public class EquiLeader
    {
        public int solution(int[] A)
        {
            if (A.Length == 1)
                return 0;
            int lastValue = -1;
            int stackSize = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (stackSize == 0)
                {
                    lastValue = A[i];
                    stackSize++;
                }
                else
                {
                    if (lastValue == A[i])
                        stackSize++;
                    else
                        stackSize--;
                }
            }
            int equiCount = 0;
            int candidate = -1;
            if (stackSize > 0)
                candidate = lastValue;
            if (candidate != -1)
            {
                int leaderCount = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == candidate)
                    {
                        leaderCount++;
                    }
                }
                if (leaderCount > A.Length / 2)
                {
                    var leader = candidate;
                    //now check the split 
                    int leaderOnLeft = 0;
                    int leaderOnRight = leaderCount;
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        if (A[i] == leader)
                        {
                            leaderOnLeft++;
                            leaderOnRight--;
                        }
                        if (leaderOnLeft > (i + 1) / 2 && leaderOnRight > (A.Length - (i + 1)) / 2)
                            equiCount++;

                    }
                    return equiCount;

                }
            }
            return 0;
        }

    }
}
