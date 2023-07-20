namespace leetcode_daily
{
    public class ClimbStairsSolution
    {
        public int ClimbStairs(int n) //4
        {
            if (n <= 2)
            {
                return n;
            }

            int[] steps = new int[n + 1];
            steps[1] = 1;
            steps[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                steps[i] = steps[i - 1] + steps[i - 2];
            }

            return steps[n];
        }
    }
}