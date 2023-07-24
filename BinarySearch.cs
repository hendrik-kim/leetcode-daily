namespace leetcode
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            return BinarySearchRecursion(nums, 0, nums.Length - 1, target);
        }

        private int BinarySearchRecursion(int[] nums, int left, int right, int target)
        {
            // If the left pointer exceeds the right pointer, it means the target does not exist in the array.
            if (left > right)
            {
                return -1;
            }

            int mid = left + (right - left) / 2; // To avoid integer overflow.

            if (nums[mid] == target)
            {
                // If the middle element is the target, return the middle index.
                return mid;
            }

            if (nums[mid] > target)
            {
                // If the middle element is greater than the target, search in the left half.
                return BinarySearchRecursion(nums, left, mid - 1, target);
            }
            else
            {
                // If the middle element is less than the target, search in the right half.
                return BinarySearchRecursion(nums, mid + 1, right, target);
            }
        }
    }
}