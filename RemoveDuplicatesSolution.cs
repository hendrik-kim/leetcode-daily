namespace leetcode
{
    public class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int resultIndex = 1;
            int prevNumber = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (prevNumber != nums[i])
                {
                    nums[resultIndex] = nums[i];
                    prevNumber = nums[i];
                    resultIndex++;
                }
            }

            return resultIndex;
        }
    }
}
