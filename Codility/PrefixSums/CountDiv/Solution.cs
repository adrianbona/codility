using System;

namespace Codility.PrefixSums.CountDiv
{
    public class Solution
    {
        public int solution(int A, int B, int K)
        {
            int result = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    int first = i / K;
                    int all = B / K;
                    result = all - first + 1;

                    break;
                }
            }
            return result;
        }
    }
}