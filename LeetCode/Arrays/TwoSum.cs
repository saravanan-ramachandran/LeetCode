using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public partial class Solution 
    {
        public int[] TwoSumV1(int[] nums, int target) 
        {
            int[] results = new int[2];
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        results[0] = i;
                        results[1] = j;
                        break;
                    }
                }
            }
            return results;
        }
        public int[] TwoSumV2(int[] nums, int target)
        {
            int[] results = new int[2];
            Dictionary<int,int> map = new Dictionary<int,int>();
            for(int i = 0; i <= nums.Length - 1; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    results[0] = map[diff];
                    results[1] = i;
                    break;
                }
                map.Add(nums[i], i);
            }
            return results;
        }
    }
}
