using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public partial class Solution
    {
        public bool IsValidAnagramV1(string s, string t)
        {
            if (s.Length != t.Length) return false;
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);
            return new string(s1) == new string(t1);
        }
        public bool IsValidAnagramV2(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] charFrequency = new int[26];
            foreach (char c in s) 
            {
                charFrequency[c - 'a']++;
            }
            foreach (char c in t)
            {
                charFrequency[c - 'a']--;
            }
            for(int i = 0; i < charFrequency.Length; i++)
            {
                if (charFrequency[i] != 0) return false;
            }
            return true;
        }

    }
}
