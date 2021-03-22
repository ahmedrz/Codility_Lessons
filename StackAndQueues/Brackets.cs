using System.Collections.Generic;

namespace Codility_Lessons.StackAndQueues
{
    public class Brackets
    {
        public int solution(string S)
        {
            Stack<char> _charStack = new Stack<char>();

            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                {'{' , '}'},
                {'(' , ')'},
                {'[' , ']'}

            };
            if (S.Length == 0)
                return 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (brackets.ContainsKey(S[i]))
                {
                    _charStack.Push(S[i]);
                }
                else
                {
                    if (_charStack.Count == 0)
                    {
                        return 0;
                    }
                    if (brackets[_charStack.Pop()] != S[i])
                        return 0;
                }
            }
            if (_charStack.Count == 0)
                return 1;
            else
                return 0;
        }

    }
}
