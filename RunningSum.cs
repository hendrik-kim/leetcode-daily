namespace leetcode_daily
{
    public class RunningSumSolution
    {
        public int[] RunningSum(int[] nums) //[1,2,3,4]
        {
            // declare same lenth of array as nums
            var result = new int[nums.Length];
            int tempSum = 0;

            //travers nums
            for (int i = 0; i < nums.Length; i++)
            {
                tempSum += nums[i];

                result[i] = tempSum;
            }

            return result;
        }
    }
}