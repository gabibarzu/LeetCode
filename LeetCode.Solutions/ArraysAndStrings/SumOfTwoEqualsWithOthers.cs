using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// Check if there exist two elements in an array whose sum is equal to the sum of rest of the array
    /// URL: https://www.geeksforgeeks.org/check-exist-two-elements-array-whose-sum-equal-sum-rest-array/
    /// Time complexity: O(n)
    /// Space complexity: O(n)
    /// </summary>
    public class SumOfTwoEqualsWithOthers
    {
        public static bool Solution(int[] array)
        {
            if (!array.Any())
            {
                return false;
            }

            var sum = array.Sum();
            if (sum % 2 == 1)
            {
                return false;
            }

            var sumOfTwo = sum / 2;
            var values = new Dictionary<int, int>();
            foreach (var item in array)
            {
                var needed = sumOfTwo - item;
                if (values.ContainsKey(needed))
                {
                    return true;
                }

                values.Add(item, needed);
            }

            return false;
        }
    }
}