namespace LeetCode.Stack
{
    public partial class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new();
            int a, b;
            foreach (var token in tokens)
            {
                if (token.Equals("+"))
                {
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(a + b);
                }
                else if (token.Equals("-"))
                {
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b - a);
                }
                else if (token.Equals("*"))
                {
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(a * b);
                }
                else if (token.Equals("/"))
                {
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b / a);
                }
                else
                {
                    stack.Push(Int32.Parse(token));
                }
            }
            return stack.Pop();
        }
    }
}