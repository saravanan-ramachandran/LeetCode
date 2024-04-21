namespace LeetCode.TwoPointers
{
    public partial class Solution
    {
        public int MaxAreaV1(int[] height)
        {
            int maxArea = Int32.MinValue;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int currentCapacity = (j - i) * Math.Min(height[i], height[j]);
                    maxArea = Math.Max(maxArea, currentCapacity);
                }
            }
            return maxArea;
        }

        public int MaxAreaV2(int[] height)
        {
            int maxArea = Int32.MinValue;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int currentCapacity = (right - left) * Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, currentCapacity);
                if (left < right)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}