namespace leetcode
{
    public class CountOddsSolution
    {
        public int CountOdds(int low, int high) // 3, 7
        {
            int result = 0;
            for (int i = low; i <= high; i++)
            {
                if (i % 2 != 0 && i != 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}