using System.Security.Principal;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 167. Two Sum II - Input Array Is Sorted
    /// URL: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    public class TwoSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var low = 0;
            var high = numbers.Length - 1;

            while (low < high)
            {
                var sum = numbers[low] + numbers[high];
                if (sum == target)
                {
                    return new[] { low + 1, high + 1 };
                }

                if (sum > target)
                {
                    high--;
                }

                if (sum < target)
                {
                    low++;
                }
            }

            return new[] { -1, -1 };
        }
    }
}