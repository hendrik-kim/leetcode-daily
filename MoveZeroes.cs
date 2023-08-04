namespace leetcode_daily
{
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums) //nums = [0,1,0,3,12]
        {
            int i = 0;

            bool isAllZero = true;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) isAllZero = false;
            }
            int tempNumb = 0;

            //traverse nums
            i = 0;
            while (!isAllZero && i < nums.Length)
            {
                //check if i is 0
                int j = i;
                if (j > 0 && nums[j - 1] == 0 && j + 1 != nums.Length) { i = 0; j = 0; }
                while (nums[j] == 0 && j < nums.Length - 1)
                {

                    tempNumb = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = tempNumb;
                    j++;

                }
                i++;
            }
        } //[1,3,12,0,0]
    }
}