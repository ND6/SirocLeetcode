using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode_0003
{
    public class Solution
    {
        public int LengthOfLongestSubstring_voilence(string s)
        {
            int slen = s.Length;
            int res = 0;
            for(int i=0;i<slen;i++)
                for(int j=0;j<slen;j++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int m = i; m < j + 1; m++)
                    {
                        sb.Append(s[m].ToString());
                    }
                    if (res < isUnique(sb.ToString()))
                    {
                        res = isUnique(sb.ToString());
                    }
                }
            return res;
        }
        private int isUnique(string subc)
        {
            for (int i = 0; i < subc.Length - 1; i++)
            {
                for (int j = i + 1; j < subc.Length; j++)
                {
                    if (subc[i] == subc[j])
                        return 0;
                }
            }
            return subc.Length;
        }

        public int LengthOfLongestSubstring(string s)//滑动窗口
        {
            List<char> ls = new List<char>();
            int n = s.Length;
            int intMaxLength = 0;
            for (int i = 0; i < n; i++)
            {
                if (ls.Contains(s[i]))
                {
                    ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);
                }
                ls.Add(s[i]);
                intMaxLength = ls.Count > intMaxLength ? ls.Count : intMaxLength;
            }
            return intMaxLength;
        }
        
    }
    class Program
    {
        private static string str = "abcabcbb";
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int len = s.LengthOfLongestSubstring(str);
            Console.WriteLine(len);
        }
    }
}
