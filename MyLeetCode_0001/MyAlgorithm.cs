using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode
{
    class MyAlgorithm
    {
        private static MyAlgorithm myAlgorithm;
        public static MyAlgorithm GetInstance()
        {
            if (myAlgorithm == null)
                myAlgorithm = new MyAlgorithm();
            return myAlgorithm;
        }
        private MyAlgorithm(){}
        /// <summary>
        /// 暴力法解 两数之和
        /// https://leetcode-cn.com/problems/two-sum/solution/liang-shu-zhi-he-by-leetcode-2/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            //int[] twoSum = new int[2];
            for (int i = 0; i < nums.Length; i++)
            { 
                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        //twoSum[0] = i;
                        //twoSum[1] = j;
                        return new  int[] { i, j };
                    }
                        
                }
            }
            return null;
        }
        public static int[] TwoSum_Dic(int[] nums,int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int,int>();
            int inKey = 0;
            foreach (int num in nums)
            {
                keyValuePairs.Add(inKey, num);
                inKey++;
            }
            for(int i=0;i<nums.Length-1;i++)
            {
                int complement = target - nums[i];
                if (keyValuePairs.ContainsValue(complement))
                {
                    foreach(KeyValuePair<int,int> keyValuePair in keyValuePairs)
                    {
                        if (keyValuePair.Value == complement && keyValuePair.Key != i)
                            return new int[] { i, keyValuePair.Key };
                    }
                }

            }
            return null;
        }

    //Definition for singly-linked list.
        public class ListNode
        {
           public int val;
           public ListNode next;
           public ListNode(int x) { val = x; }
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;

            //return null;
        }
    }
}
