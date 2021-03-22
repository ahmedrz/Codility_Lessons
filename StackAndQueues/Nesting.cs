using System.Collections.Generic;

namespace Codility_Lessons.StackAndQueues
{
    public class Nesting
    {
        public int solution(string S)
        {
            if (S.Length == 0)
                return 1;
            if (S.Length == 1)
                return 0;
            Stack<char> _stack = new Stack<char>();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    _stack.Push(S[i]);
                else
                {
                    if (_stack.Count == 0)
                        return 0;
                    _stack.Pop();
                }
            }
            if (_stack.Count == 0)
                return 1;
            else
                return 0;
        }

    }
}
