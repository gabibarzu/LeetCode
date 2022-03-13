using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Solutions.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.LinkedList
{
    [TestClass]
    public class ReverseLinkedListTests
    {
        private static int[] CastToArray(ReverseLinkedList.ListNode list)
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
            var head = new ReverseLinkedList.ListNode(1, new ReverseLinkedList.ListNode(2, new ReverseLinkedList.ListNode(3)));
            var solution = ReverseLinkedList.ReverseListIterative(head);
            CastToArray(solution).Should().Contain(new[] { 3, 2, 1 });
        }
    }
}