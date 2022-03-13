namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 33. Search in Rotated Sorted Array
    /// URL: https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class SearchInRotatedSortedArray
    {
        /// <summary>
        /// Binary tree approach
        /// Time: O(n log n)
        /// Space: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var midpoint = left + (right - left) / 2;
                if (nums[midpoint] > nums[right])
                {
                    left = midpoint + 1;
                }
                else
                {
                    right = midpoint;
                }
            }

            var start = left;
            left = 0;
            right = nums.Length - 1;

            if (target >= nums[start] && target <= nums[right])
            {
                left = start;
            }
            else
            {
                right = start;
            }

            while (left <= right)
            {
                var midpoint = left + (right - left) / 2;
                if (nums[midpoint] == target)
                {
                    return midpoint;
                }
                else
                {
                    right = midpoint - 1;
                }
            }

            return -1;
        }
    }
}