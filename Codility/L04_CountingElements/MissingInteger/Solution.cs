using System;

namespace Codility.CountingElements.MissingInteger
{
    public class Solution
    {
        public int solution(int[] A)
        {
            A = Array.FindAll(A, x => x > 0);
            Array.Sort(A);

            int missing = 1;
            int length = A.Length;

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    if (A[i] > 1)
                    {
                        missing = 1;
                        break;
                    }
                    else
                    {
                        missing = 2;
                    }
                }
                else
                {
                    if (A[i] - 1 > A[i - 1])
                    {
                        missing = A[i - 1] + 1;
                        break;
                    }
                    else
                    {
                        missing = A[i] + 1;
                    }
                }
            }

            return missing;
        }
    }
}