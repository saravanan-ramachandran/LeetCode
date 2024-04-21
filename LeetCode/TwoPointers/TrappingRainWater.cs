namespace LeetCode.TwoPointers
{
    public partial class Solution
    {
        public int TrapV1(int[] height)
        {
            int length = height.Length;
            int trappedWater = 0;
            for (int i = 0; i < length; i++)
            {
                int j = i;
                int leftMax = 0;
                int rightMax = 0;
                while (j >= 0)
                {
                    leftMax = Math.Max(leftMax, height[j]);
                    j--;
                }
                j = i;
                while (j < length)
                {
                    rightMax = Math.Max(rightMax, height[j]);
                    j++;
                }
                trappedWater += Math.Min(leftMax, rightMax) - height[i];
            }
            return trappedWater;
        }

        public int TrapV2(int[] height)
        {
            int length = height.Length;
            int trappedWater = 0;
            int[] prefix = new int[length];
            int[] suffix = new int[length];
            prefix[0] = height[0];
            for (int i = 1; i < length; i++)
            {
                prefix[i] = Math.Max(prefix[i - 1], height[i]);
            }
            suffix[length - 1] = height[length - 1];
            for (int j = length - 2; j > 0; j--)
            {
                suffix[j] = Math.Max(suffix[j + 1], height[j]);
            }
            for (int i = 0; i < length; i++)
            {
                trappedWater += Math.Min(prefix[i], suffix[i]) - height[i];
            }
            return trappedWater;
        }

        public int TrapV3(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxLeft = 0;
            int maxRight = 0;
            int trappedWater = 0;
            while (left <= right)
            {
                if (height[left] <= height[right])
                {
                    if (height[left] >= maxLeft)
                    {
                        maxLeft = height[left];
                    }
                    else
                    {
                        trappedWater += maxLeft - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= maxRight)
                    {
                        maxRight = height[right];
                    }
                    else
                    {
                        trappedWater += maxRight - height[right];
                    }
                    right--;
                }
            }
            return trappedWater;
        }
    }
}