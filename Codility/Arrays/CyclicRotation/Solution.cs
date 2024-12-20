using System;

namespace Codility.Arrays.CyclicRotation
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int length = A.Length;
            int value = A[0];
            Array.Sort(A);

            if (length == 1)
            {
                return value;
            }

            for (int i = 0; i < length - 1; i = i + 2)
            {
                if (A[i] != A[i + 1])
                {
                    return A[i];
                }
            }

            return A[length - 1];
        }
    }
}