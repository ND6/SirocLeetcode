using System;

namespace LeetCode_0002
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            ListNode prenode = new ListNode(0);
            ListNode lastnode = prenode;
            while (l1 != null || l2 != null || val != 0)
            {
                val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                lastnode.next = new ListNode(val % 10);//当前位的值
                lastnode = lastnode.next;
                val = val / 10;//进位位
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return prenode.next;
        }
    }

    class Test
    {
        static ListNode generateList(int[] vals)
        {
            ListNode res = null;
            ListNode last = null;
            foreach (var val in vals)
            {
                if (res is null)
                {
                    res = new ListNode(val);
                    last = res;
                }
                else
                {
                    last.next = new ListNode(val);
                    last = last.next;
                }
            }
            return res;
        }

        static void printList(ListNode l)
        {
            while (l != null)
            {
                Console.Write($"{l.val}, ");
                l = l.next;
            }
            Console.WriteLine("");
        }

        static void Main()
        {
            var l1 = generateList(new int[] { 1, 5, 7 });
            var l2 = generateList(new int[] { 9, 8, 2, 9 });
            printList(l1);
            printList(l2);
            Solution s = new Solution();
            var sum = s.AddTwoNumbers(l1, l2);
            printList(sum);
        }
    }
}
