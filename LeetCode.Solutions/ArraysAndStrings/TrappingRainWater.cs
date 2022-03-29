namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 42. Trapping Rain Water
    /// URL: https://leetcode.com/problems/trapping-rain-water
    /// Time complexity: O(n)
    /// Space complexity: O(1)
    /// </summary>
    public class TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var maxLeft = height[left];
            var maxRight = height[right];
            var water = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= maxLeft)
                    {
                        maxLeft = height[left];
                    }
                    else
                    {
                        water += (maxLeft - height[left]);
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= maxRight)
                    {
                        maxRight = height[right];
                    }
                    else
                    {
                        water += maxRight - height[right];
                    }
                    right--;
                }
            }

            return water;
        }
    }
}