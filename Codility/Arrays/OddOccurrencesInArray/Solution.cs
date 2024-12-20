namespace Codility.OddOccurrencesInArray
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            int length = A.Length;

            if (K == 0 || length < 2)
            {
                return A;
            }

            while (K > 0)
            {
                int first = A[0];
                int second = A[1];

                for (int i = 0; i < length; i++)
                {
                    A[(i + 1) % length] = first;
                    first = second;
                    second = A[(i + 2) % length];
                }
                K--;
            }
            return A;
        }
    }
}