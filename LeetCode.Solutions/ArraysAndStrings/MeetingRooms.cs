using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 252. Meeting Rooms
    /// URL: https://leetcode.com/problems/meeting-rooms/
    /// Time complexity: O (n log n)
    /// Time complexity: O (1)
    /// </summary>
    public class MeetingRooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            for (var i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0])
                {
                    return false;
                }
            }
            return true;
        }
    }
}