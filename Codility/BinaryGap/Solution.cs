using System;

namespace Codility.BinaryGap
{
    public class Solution
    {
        public int solution(int N)
        {
            int size = 0;
            string binary = Convert.ToString(N, 2);
            int first = binary.IndexOfAny("1".ToCharArray());
            if (first == -1)
            {
                return size;
            }

            int second = binary.IndexOfAny("1".ToCharArray(), first + 1);
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
                second = binary.IndexOfAny("1".ToCharArray(), first + 1);
            }

            return size;
        }
    }
}