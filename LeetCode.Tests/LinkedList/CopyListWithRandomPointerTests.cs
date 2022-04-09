using FluentAssertions;
using LeetCode.Solutions.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.LinkedList
{
    [TestClass]
    public class CopyListWithRandomPointerTests
    {
        [TestMethod]
        public void Test_1()
        {
            var node1 = new CopyListWithRandomPointer.Node(7);
            var node2 = new CopyListWithRandomPointer.Node(13);
            var node3 = new CopyListWithRandomPointer.Node(11);
            var node4 = new CopyListWithRandomPointer.Node(10);
            var node5 = new CopyListWithRandomPointer.Node(1);

            node1.next = node2;
            node1.random = null;

            node2.next = node3;
            node2.random = node1;

            node3.next = node4;
            node3.random = node5;

            node4.next = node5;
            node4.random = node3;

            node5.next = null;
            node5.random = node1;

            var result = CopyListWithRandomPointer.CopyRandomList(node1);

            result.Should().Be(node1);
        }
    }
}