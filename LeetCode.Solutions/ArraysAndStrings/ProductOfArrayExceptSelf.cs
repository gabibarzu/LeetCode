namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 238. Product of Array Except Self
    /// URL: https://leetcode.com/problems/product-of-array-except-self/
    /// </summary>
    public class ProductOfArrayExceptSelf
    {
        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            var leftProduct = new int[nums.Length];
            var rightProduct = new int[nums.Length];
            var result = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    leftProduct[i] = 1;
                }
                else
                {
                    leftProduct[i] = nums[i - 1] * leftProduct[i - 1];
                }
            }

            for (var j = nums.Length - 1; j >= 0; j--)
            {
                if (j == nums.Length - 1)
                {
                    rightProduct[j] = 1;
                }
                else
                {
                    rightProduct[j] = nums[j + 1] * rightProduct[j + 1];
                }
            }

            for (var k = 0; k < nums.Length; k++)
            {
                result[k] = leftProduct[k] * rightProduct[k];
            }

            return result;
        }
        
        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelfOptimized(int[] nums)
        {
            var result = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = nums[i - 1] * result[i - 1];
                }
            }

            var right = 1;
            for (var j = nums.Length - 1; j >= 0; j--)
            {
                result[j] = right * result[j];
                right *= nums[j];   
            }

            return result;
        }
    }
}