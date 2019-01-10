namespace Codility.PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A)
        {
            uint length = (uint)A.Length;
            ulong arithmetic = (length + 1) * (1 + (length + 1)) / 2;

            for (int i = 0; i < length; i++)
            {
                arithmetic -= (uint)A[i];
            }

            return (int)arithmetic;
        }
    }
}