using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.SortingAndSearching
{
    /// <summary>
    /// 56. Merge Intervals
    /// URL: https://leetcode.com/problems/merge-intervals/
    /// Time complexity: O(N log N)
    /// Space complexity: O(N)
    /// </summary>
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            var merged = new List<int[]>();
            foreach (var interval in intervals)
            {
                // if the list of merged intervals is empty or if the current
                // interval does not overlap with the previous, simply append it.
                if (!merged.Any() || merged.Last()[1] < interval[0])
                {
                    merged.Add(interval);
                }
                // otherwise, there is overlap, so we merge the current and previous
                // intervals.
                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }

            return merged.ToArray();
        }
    }
}