namespace Codility.FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            return (Y - X) / D + ((Y - X) % D > 0 ? 1 : 0);
        }
    }
}