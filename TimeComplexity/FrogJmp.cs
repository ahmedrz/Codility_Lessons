namespace Codility_Lessons.TimeComplexity
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y)
            {
                return 0;
            }
            var reminder = (Y - X) % D;
            if (reminder == 0)
            {
                return (Y - X) / D;
            }
            else
            {
                return ((Y - X) / D) + 1;
            }
        }
    }
}
