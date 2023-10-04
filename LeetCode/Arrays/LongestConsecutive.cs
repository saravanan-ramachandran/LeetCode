using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace LeetCode.Arrays
{
    public partial class Solution
    {
        //public int LongestConsecutiveV1(int[] nums)
        //{
        //    return 0;
        //}
        //public int LongestConsecutiveV2(int[] nums)
        //{
        //    return 0;
        //}
        public int LongestConsecutiveV3(int[] nums)
        {
            int longestSequence = 0;
            
            HashSet<int> visited = new(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int currentSequence = 0;
                if (!visited.Contains(nums[i] - 1))
                {
                    while (visited.Contains(nums[i] + currentSequence))
                    {
                        currentSequence++;
                    }
                }
                longestSequence = Math.Max(longestSequence, currentSequence);
            }
            return longestSequence;
        }
    }
}
