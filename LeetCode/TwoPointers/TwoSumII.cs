namespace LeetCode.TwoPointers
{
    public partial class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int[] result = new int[2];
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    result[0] = left;
                    result[1] = right;
                    break;
                }
            }
            return result;
        }
    }
}