using System;

namespace LeetCode.Solutions.SortingAndSearching
{
    /// <summary>
    /// 215. Kth Largest Element in an Array
    /// URL: https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// </summary>
    public class KthLargestElementInAnArray
    {
        /// <summary>
        /// With sort array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindKthLargestWithSortArray(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[^k];
        }
    }
}