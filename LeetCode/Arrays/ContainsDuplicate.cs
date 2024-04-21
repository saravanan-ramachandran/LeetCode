namespace LeetCode.Arrays;

public partial class Solution
{
    //Time Complexity O(N^2), Space Complexity O(1)
    public bool ContainsDuplicateV1(int[] nums)
    {
        //No duplicates if there are no more than 1 num
        if (nums.Length <= 1)
        {
            return false;
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    return true;
                }
            }
        }
        return false;
    }

    //Time Complexity O(N log N), Space Complexity O(1)
    public bool ContainsDuplicateV2(int[] nums)
    {
        //No duplicates if there are no more than 1 num
        if (nums.Length <= 1)
        {
            return false;
        }
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        return false;
    }

    //Time Complexity O(N), Space Complexity O(N)
    public bool ContainsDuplicateV3(int[] nums)
    {
        //No duplicates if there are no more than 1 num
        if (nums.Length <= 1)
        {
            return false;
        }
        HashSet<int> bag = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!bag.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}