using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public partial class Solution
    {
        //public IList<IList<int>> ThreeSumV1(int[] nums)
        //{

        //}
        //public IList<IList<int>> ThreeSumV2(int[] nums)
        //{

        //}
        public List<List<int>> ThreeSumV3(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                if ( i > 0 && key == nums[i-1] )
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while(left < right)
                {
                    int sum = key + nums[left] + nums[right];
                    if ( sum > 0 )
                    {
                        right--;
                    }
                    else if ( sum < 0 )
                    {
                        left++;
                    }
                    else
                    {
                        result.Add(new List<int> { key, nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right)
                            left++;
                    }
                }
            }
            return result;
        }
    }
}
