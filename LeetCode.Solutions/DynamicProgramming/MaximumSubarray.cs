using System;

namespace LeetCode.Solutions.DynamicProgramming
{
    /// <summary>
    /// 53. Maximum Subarray
    /// Url: https://leetcode.com/problems/maximum-subarray/
    /// Time complexity: O(n)
    /// Space complexity: O(1)
    /// </summary>
    public class MaximumSubArray
    {
        public int maxSubArray(int[] nums)
        {
            // Initialize our variables using the first element.
            var currentSubArray = nums[0];
            var maxSubArray = nums[0];

            // Start with the 2nd element since we already used the first one.
            for (var i = 1; i < nums.Length; i++)
            {
                var num = nums[i];
                // If current_subarray is negative, throw it away. Otherwise, keep adding to it.
                currentSubArray = Math.Max(num, currentSubArray + num);
                maxSubArray = Math.Max(maxSubArray, currentSubArray);
            }

            return maxSubArray;
        }
    }
}