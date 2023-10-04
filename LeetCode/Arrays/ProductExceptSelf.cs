using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public partial class Solution 
    {
        //public int[] ProductExceptSelfV1(int[] nums)
        //{

        //}
        //public int[] ProductExceptSelfV2(int[] nums)
        //{

        //}
        public int[] ProductExceptSelfV3(int[] nums)
        {
            int prefix = 1;
            int[] result = new int[nums.Length];
            int suffix = 1;
            Array.Fill(result, prefix);

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] *= prefix;
                prefix *= nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }
    }
}
