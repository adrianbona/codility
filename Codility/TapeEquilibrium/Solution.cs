using System;

namespace Codility.TapeEquilibrium
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int length = A.Length;

            int firstHalf = A[0];
            int secondHalf = 0;

            for (int i = 1; i < length; i++)
            {
                secondHalf += A[i];
            }

            int minDiff = Math.Abs(firstHalf - secondHalf);

            for (int i = 1; i < length - 1; i++)
            {
                firstHalf += A[i];
                secondHalf -= A[i];

                int diff = Math.Abs(firstHalf - secondHalf);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            return minDiff;
        }
    }
}