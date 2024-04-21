namespace LeetCode.Stack
{
    public partial class Solution
    {
        public bool IsValidV1(string s)
        {
            Stack<char> str = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    str.Push(s[i]);
                }
                else
                {
                    char c = str.Peek();
                    if ((c == '(' && s[i] == ')') || (c == '{' && s[i] == '}') || (c == '[' && s[i] == ']'))
                    {
                        str.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return str.Count == 0;
        }
    }
}