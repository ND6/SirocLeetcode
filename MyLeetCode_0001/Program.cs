using System;
using System.Text;
using static MyLeetCode.MyAlgorithm;

namespace MyLeetCode
{
    class Program
    {
        private static MyAlgorithm myAlgorithm;
        public Program()
        {
            myAlgorithm = MyAlgorithm.GetInstance();
        }
        public static int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            tryTwoSum();
            Console.ReadLine();
        }
      
        private static void tryTwoSum()
        {
            int[] test;// = new int[2];
            test = MyAlgorithm.TwoSum_Dic(nums, 8);
            StringBuilder sb = new StringBuilder(2);
            foreach (int num in test)
            {
                sb.Append(num.ToString());
            }
            Console.WriteLine(sb);
        }
        private static void tryAddTwoNumbers()
        {
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(5);
            l1.next = l2;
            l2.next = l3;
        }
    }
}
