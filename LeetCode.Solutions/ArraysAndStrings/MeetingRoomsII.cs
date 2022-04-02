using System;
using System.Linq;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 253. Meeting Rooms II
    /// Url: https://leetcode.com/problems/meeting-rooms-ii/
    /// Time complexity: O (n log n)
    /// Space complexity: O (n)
    /// </summary>
    public class MeetingRoomsII
    {
        public static int MinMeetingRooms(int[][] intervals)
        {
            if (!intervals.Any())
            {
                return 0;
            }

            var start = new int[intervals.Length];
            var end = new int[intervals.Length];

            for (var i = 0; i < intervals.Length; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }

            Array.Sort(start);
            Array.Sort(end);

            var startPointer = 0;
            var endPointer = 0;

            var count = 0;
            var result = 0;

            while (startPointer < intervals.Length)
            {
                if (start[startPointer] < end[endPointer])
                {
                    startPointer += 1;
                    count += 1;
                }
                else
                {
                    endPointer += 1;
                    count -= 1;
                }

                result = Math.Max(result, count);
            }

            return result;
        }
    }
}