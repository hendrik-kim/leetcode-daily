namespace leetcode_daily.DynamicProgramming
{
    public class HouseRobberSolution
    {
        public int Rob(int[] nums) //[2,7,9,3,1]
        {
            if (nums.Length == 0 || nums == null) return 0;
            if (nums.Length == 1) return nums[0];

            int[] dp = new int[nums.Length];

            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }

            return dp[nums.Length - 1];

        }//rob = 2 + 9 + 1 = 12.
    }
}