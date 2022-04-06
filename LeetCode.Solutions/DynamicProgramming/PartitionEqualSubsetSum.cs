using System.Linq;

namespace LeetCode.Solutions.DynamicProgramming
{
    /// <summary>
    /// 416. Partition Equal Subset Sum
    /// Url: https://leetcode.com/problems/partition-equal-subset-sum/
    /// </summary>
    public class PartitionEqualSubsetSum
    {
        public static bool CanPartition(int[] nums)
        {
            var sum = nums.Sum();

            if (sum % 2 == 1)
            {
                return false;
            }

            if (nums.Length == 2)
            {
                return nums[0] == nums[1];
            }

            var half = sum / 2;
            var halfResult = 0;
            foreach (var num in nums)
            {
                if (num < half && halfResult + num <= half)
                {
                    halfResult += num;
                }

                if (halfResult == half)
                {
                    return true;
                }
            }

            return false;
        }
    }
}