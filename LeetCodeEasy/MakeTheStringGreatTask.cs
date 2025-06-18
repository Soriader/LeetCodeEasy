namespace LeetCodeEasy;

public class MakeTheStringGreatTask
{
    public static string MakeGood(string s)
    {
        Stack<char> stack = new Stack<char>();
    
        foreach (char currentChar in s)
        {
            if (stack.Count > 0 && 
                Math.Abs(stack.Peek() - currentChar) == 32)
            {
                stack.Pop();  
            }
            else
            {
                stack.Push(currentChar);
            }
        }
    
        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
//https://leetcode.com/problems/make-the-string-great/description/