using System.Collections.Generic;

namespace Codility.FrogRiverOne
{
    public class Solution
    {
        public int solution(int X, int[] A)
        {
            int length = A.Length;
            int counter = 0;
            HashSet<int> bag = new HashSet<int>();

            for (int i = 0; i < length && bag.Count < X; i++)
            {
                counter = i;
                if (A[i] <= X)
                {
                    bag.Add(A[i]);
                }
            }

            if (bag.Count != X)
            {
                counter = -1;
            }

            return counter;
        }
    }
}