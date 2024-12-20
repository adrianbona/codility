using System.Collections.Generic;

namespace Codility.GenomicRangeQuery
{
    public class Solution
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            Dictionary<char, int> values = new Dictionary<char, int>() { { 'A', 1 }, { 'C', 2 }, { 'G', 3 }, { 'T', 4 } };
            Dictionary<int, char> reverse = new Dictionary<int, char>() { { 1, 'A' }, { 2, 'C' }, { 3 , 'G' }, { 4, 'T' } };

            int N = S.Length;
            int M = P.Length;
            int nucleotides = values.Count;

            int[] result = new int[M];
            for (int i = 0; i < M; i++)
            {
                result[i] = int.MaxValue;
            }

            int[,] prefix = new int[N, nucleotides];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < nucleotides; j++)
                {
                    if (i == 0)
                    {
                        prefix[i, j] = j == values[S[i]] - 1 ? 1 : 0;
                    }
                    else
                    {
                        prefix[i, j] = prefix[i - 1, j] + (j == values[S[i]] - 1 ? 1 : 0);
                    }
                }
            }

            for (int i = 0; i < M; i++)
            {
                if (P[i] != Q[i])
                {
                    for (int j = 0; j < nucleotides; j++)
                    {
                        int upperBound = prefix[Q[i], j];
                        int lowerBound = P[i] == 0 ? 0 : prefix[P[i], j];

                        if (upperBound - lowerBound > 0)
                        {
                            result[i] = result[i] > values[reverse[j + 1]] ? values[reverse[j + 1]] : result[i];
                        }
                    }
                }
                else
                {
                    result[i] = values[S[P[i]]];
                }
            }

            return result;
        }
    }
}