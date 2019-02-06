namespace Codility.MinimumDeletions
{
    public class Solution
    {
        public int solution(string S)
        {
            var result = 0;
            var letters = S.ToCharArray();
            int[] prefix = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                prefix[i] = 1;
            }

            for (int i = 1; i < S.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (letters[i] > letters[j] && prefix[i] < prefix[j] + 1)
                    {
                        prefix[i] = prefix[j] + 1;
                        if(prefix[i] > result)
                        {
                            result = prefix[i];
                        }
                    }
                }
            }

            return S.Length - result;
        }
    }
}