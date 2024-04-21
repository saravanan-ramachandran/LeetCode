namespace LeetCode.Arrays;

public partial class Solution
{
    //Time Complexity - O(N * K * log K)
    // n - no of strings, k - maximum length of string
    //Space Complexity - O(N*K)
    //N - No.of groups and K - Maximum Length of string
    public List<List<string>> GroupAnagramsV1(string[] strs)
    {
        List<List<string>> result = new();
        Dictionary<string, List<string>> groupAnagrams = new();
        foreach (var str in strs)
        {
            char[] c = str.ToCharArray();
            Array.Sort(c);
            string k = new(c);
            if (groupAnagrams.ContainsKey(k))
            {
                groupAnagrams[k].Add(str);
            }
            else
            {
                groupAnagrams.Add(k, new List<string> { str });
            }
        }
        foreach (var g in groupAnagrams)
        {
            result.Add(g.Value);
        }
        return result;
    }

    //Time Complexity - O(N * K)
    // n - no of strings, k - maximum length of string
    //Space Complexity - O(N * K)
    //N - No.of groups and K - Maximum Length of string
    public List<List<string>> GroupAnagramsV2(string[] strs)
    {
        List<List<string>> result = new();
        Dictionary<string, List<string>> groupAnagrams = new();
        foreach (var str in strs)
        {
            char[] c = new char[26];
            foreach (var ch in str)
            {
                c[ch - 'a']++;
            }
            string k = new(c);
            if (groupAnagrams.ContainsKey(k))
            {
                groupAnagrams[k].Add(str);
            }
            else
            {
                groupAnagrams.Add(k, new List<string> { str });
            }
        }
        foreach (var g in groupAnagrams)
        {
            result.Add(g.Value);
        }
        return result;
    }
}