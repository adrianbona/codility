namespace Codility.CountingElements.MaxCounters
{
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int length = A.Length;
            int[] counters = new int[N];

            int[] indexer = new int[length];
            indexer[0] = N;

            bool maxApplied = true;
            int max = 0;

            for (int i = 0; i < length; i++)
            {
                if (A[i] > N)
                {
                    if (!maxApplied)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            counters[j] = max;
                        }
                        maxApplied = true;
                    }
                }
                else
                {
                    int value = counters[A[i] - 1] + 1;
                    counters[A[i] - 1] = value;
                    if (value > max)
                    {
                        max = value;
                    }
                    maxApplied = false;
                }
            }

            return counters;
        }
    }
}