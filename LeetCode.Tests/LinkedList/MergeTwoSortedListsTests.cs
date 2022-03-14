using System.Collections.Generic;

using LeetCode.Solutions.LinkedList;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.LinkedList
{
    [TestClass]
    public class MergeTwoSortedListsTests
    {
        private static int[] CastToArray(MergeTwoSortedLists.ListNode list)
        {
            var result = new List<int>();
            while (list != null)
            {
                result.Add(list.Val);
                list = list.Next;
            }

            return result.ToArray();
        }

        [TestMethod]
        public void Test_1()
        {
            var l1 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2, new MergeTwoSortedLists.ListNode(4)));
            var l2 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(3, new MergeTwoSortedLists.ListNode(4)));
            var solution = MergeTwoSortedLists.Solution(l1, l2);
            CastToArray(solution).Should().Contain(new[] { 1, 1, 2, 3, 4, 4 });
        }
    }
}