using System.Collections.Generic;

namespace Codility.CountingElements.PermCheck
{
    public class Solution
    {
        public int solution(int[] A)
        {
            HashSet<ulong> bag = new HashSet<ulong>();
            ulong length = (ulong)A.Length;
            ulong arithmetic = length * (1 + length) / 2;

            for (ulong i = 0; i < length; i++)
            {
                if ((ulong)A[i] > length)
                {
                    return 0;
                }
                arithmetic -= (ulong)A[i];
                bag.Add((ulong)A[i]);
            }

            if ((ulong)bag.Count < length)
            {
                return 0;
            }

            return arithmetic == 0 ? 1 : 0;
        }
    }
}