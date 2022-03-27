using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public class ThreeSum
    {
        public static IList<IList<int>> ThreeSumSolution(int[] nums)
        {
            Array.Sort(nums);

            var result = new List<IList<int>>();

            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    TwoSumII(nums, i, result);
                }
            }

            return result;
        }

        private static void TwoSumII(int[] nums, int i, IList<IList<int>> result)
        {
            // Two sum 2
            var low = i + 1;
            var high = nums.Length - 1;

            while (low < high)
            {
                var sum = nums[i] + nums[low] + nums[high];
                switch (sum)
                {
                    case < 0:
                        low++;
                        break;
                    case > 0:
                        high--;
                        break;
                    case 0:
                        {
                            result.Add(new List<int> { nums[i], nums[low], nums[high] });
                            while (low < high && nums[low] == nums[low - 1])
                            {
                                low++;
                            }

                            while (low < high && nums[high] == nums[high - 1])
                            {
                                high++;
                            }

                            break;
                        }
                }
            }
        }
    }
}
