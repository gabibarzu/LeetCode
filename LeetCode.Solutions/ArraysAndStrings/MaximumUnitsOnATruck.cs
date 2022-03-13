using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 1710. Maximum Units on a Truck
    /// URL: https://leetcode.com/problems/maximum-units-on-a-truck/
    /// </summary>
    public class MaximumUnitsOnATruck
    {
        /// <summary>
        /// Using Array Sort
        /// Time: O (n log n)
        /// Space: O (1)
        /// </summary>
        /// <param name="boxTypes"></param>
        /// <param name="truckSize"></param>
        /// <returns></returns>
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
            var unitCount = 0;
            foreach (var boxType in boxTypes)
            {
                var boxCount = Math.Min(truckSize, boxType[0]);
                unitCount += boxCount * boxType[1];
                truckSize -= boxCount;
                if (truckSize == 0)
                {
                    break;
                }
            }
            return unitCount;
        }
    }
}