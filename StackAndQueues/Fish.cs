using System.Collections.Generic;

namespace Codility_Lessons.StackAndQueues
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            if (A.Length == 1)
                return 1;
            int freeFishes = 0;

            Stack<int> downStream = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0)
                {
                    if (downStream.Count == 0)
                    {
                        freeFishes++;
                    }
                    else
                    {
                        var downStreamFish = downStream.Pop();
                        while (downStreamFish < A[i])
                        {
                            if (downStream.Count > 0)
                                downStreamFish = downStream.Pop();
                            else
                            {
                                freeFishes++;
                                downStreamFish = -1;
                                break;
                            }
                        }
                        if (downStreamFish != -1)
                            downStream.Push(downStreamFish);

                    }
                }
                else
                {
                    downStream.Push(A[i]);
                }

            }
            freeFishes += downStream.Count;
            return freeFishes;

        }

    }
}
