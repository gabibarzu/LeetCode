using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.LinkedList
{
    public class MergeKSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        /// <summary>
        /// 23. Merge k Sorted Lists
        /// Url: https://leetcode.com/problems/merge-k-sorted-lists/
        /// Time complexity: O(n log k)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (!lists.Any())
            {
                return null;
            }

            while (lists.Length > 1)
            {
                var mergedLists = new List<ListNode>();
                for (var i = 0; i < lists.Length; i += 2)
                {
                    var list1 = lists[i];
                    var list2 = i + 1 < lists.Length ? lists[i + 1] : null;
                    mergedLists.Add(this.MergeTwoLists(list1, list2));
                }

                lists = mergedLists.ToArray();
            }

            return lists[0];
        }

        private ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var result = new ListNode();
            var current = result;

            while (list1 != null && list2 != null)
            {

                if (list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }

                current = current.next;
            }

            if (list1 == null)
            {
                while (list2 != null)
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                    current = current.next;
                }
            }

            if (list2 == null)
            {
                while (list1 != null)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                    current = current.next;
                }
            }

            return result.next;
        }
    }
}