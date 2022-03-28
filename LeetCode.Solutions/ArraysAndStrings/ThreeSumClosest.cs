using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public class ThreeSumClosest
    {
        public static int ThreeSumClosestSolution(int[] nums, int target)
        {
            var difference = int.MaxValue;
            var size = nums.Length;
            Array.Sort(nums);


            for (var i = 0; i < size && difference != 0; i++)
            {
                var low = i + 1;
                var high = size - 1;

                while (low < high)
                {
                    var sum = nums[i] + nums[low] + nums[high];
                    if (Math.Abs(target - sum) < Math.Abs(difference))
                    {
                        difference = target - sum;
                    }

                    if (sum < target)
                    {
                        low++;
                    }

                    if (sum > target)
                    {
                        high--;
                    }
                }
            }

            return target - difference;
        }
    }
}
