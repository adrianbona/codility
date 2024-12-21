using System;

namespace Codility.BinaryGap
{
    public class Solution
    {
        public int solution(int N)
        {
            int size = 0;
            string binary = Convert.ToString(N, 2);
            int first = binary.IndexOf('1');
            if (first == -1)
            {
                return size;
            }

            int second = binary.IndexOf('1', first + 1);
            if (second == -1)
            {
                return size;
            }

            while (second != -1)
            {
                if (size < second - first)
                {
                    size = second - first - 1;
                }

                first = second;
                second = binary.IndexOf('1', first + 1);
            }

            return size;
        }
    }
}