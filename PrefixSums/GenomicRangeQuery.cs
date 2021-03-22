namespace Codility_Lessons.PrefixSums
{
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];
            int[][] positions = new int[4][];
            int[][] preFix = new int[4][];
            //fill positions 
            for (int i = 0; i < 4; i++)
            {
                positions[i] = new int[S.Length];
            }  //fill preFix 
            for (int i = 0; i < S.Length; i++)
            {
                switch (S[i])
                {
                    case 'A':
                        { positions[0][i]++; }
                        break;
                    case 'C':
                        { positions[1][i]++; }
                        break;
                    case 'G':
                        { positions[2][i]++; }
                        break;
                    case 'T':
                        { positions[3][i]++; }
                        break;

                }
            }
            for (int i = 0; i < 4; i++)
            {
                preFix[i] = new int[S.Length + 1];
                for (int j = 0; j < S.Length + 1; j++)
                {
                    if (j == 0)
                    {
                        //file the first position in prefix
                        preFix[i][0] = 0;
                        continue;
                    }
                    preFix[i][j] = preFix[i][j - 1] + positions[i][j - 1];

                }

            }
            for (int i = 0; i < P.Length; i++)
            {
                var from = P[i];
                var to = Q[i];
                if (preFix[0][to + 1] - preFix[0][from] > 0)
                {
                    result[i] = 1;
                }
                else if (preFix[1][to + 1] - preFix[1][from] > 0)
                {
                    result[i] = 2;
                }
                else if (preFix[2][to + 1] - preFix[2][from] > 0)
                {
                    result[i] = 3;
                }
                else if (preFix[3][to + 1] - preFix[3][from] > 0)
                {
                    result[i] = 4;
                }
            }
            return result;

        }

    }
}
