namespace Codility.PasssingCars
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int length = A.Length;
            int passingCars = 0;
            int zeros = 0;

            if (length > 1)
            {
                for (int i = 0; i < length; i++)
                {
                    if (A[i] == 0)
                    {
                        zeros++;
                    }
                    else
                    {
                        passingCars += zeros;
                        if (passingCars > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }

            return passingCars;
        }
    }
}