namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 704. Binary Search
    /// URL: https://leetcode.com/problems/binary-search/
    /// Time: O(n log n)
    /// Space: O(1) 
    /// </summary>
    public class BinarySearchTree
    {
        public static int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var pivot = left + (right - left) / 2;
                if (nums[pivot] == target)
                {
                    return pivot;
                }

                if (target < nums[pivot])
                {
                    right = pivot - 1;
                }
                else
                {
                    left = pivot + 1;
                }
            }

            return -1;
        }
    }
}