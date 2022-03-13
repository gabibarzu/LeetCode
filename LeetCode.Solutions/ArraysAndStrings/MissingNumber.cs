using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class MissingNumber
    {
        public static int Solution(int[] nums)
        {
            var sortedSet = new SortedSet<int>(nums);
            var max = nums.Length + 1;

            for (var number = 0; number < max; number++)
            {
                if (!sortedSet.Contains(number))
                {
                    return number;
                }
            }
            return -1;
        }
    }
}