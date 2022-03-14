using System.Collections.Generic;

using LeetCode.Solutions.LinkedList;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.LinkedList
{
    [TestClass]
    public class AddTwoNumbersTests
    {
        private static int[] CastToArray(AddTwoNumbers.ListNode list)
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
            var l1 = new AddTwoNumbers.ListNode(2, new AddTwoNumbers.ListNode(4, new AddTwoNumbers.ListNode(3)));
            var l2 = new AddTwoNumbers.ListNode(5, new AddTwoNumbers.ListNode(6, new AddTwoNumbers.ListNode(4)));
            var solution = AddTwoNumbers.Solution(l1, l2);
            CastToArray(solution).Should().Contain(new[] { 7, 0, 8 });
        }
    }
}