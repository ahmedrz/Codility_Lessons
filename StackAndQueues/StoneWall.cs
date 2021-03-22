using System.Collections.Generic;
using System.Linq;

namespace Codility_Lessons.StackAndQueues
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            if (H.Length == 1)
                return 1;
            int blocks = 0;
            Stack<int> _stack = new Stack<int>();
            for (int i = 0; i < H.Length; i++)
            {
                if (_stack.Count == 0)
                    _stack.Push(H[i]);
                else
                {
                    if (H[i] == _stack.Peek())
                    {
                        continue;
                    }
                    else if (H[i] > _stack.Peek())
                    {
                        _stack.Push(H[i]);
                    }
                    else
                    {
                        _stack.Pop();
                        blocks++;
                        i--;
                    }
                }

            }
            return blocks + _stack.Count();
        }

    }
}
