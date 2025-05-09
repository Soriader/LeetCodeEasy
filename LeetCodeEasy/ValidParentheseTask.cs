namespace LeetCodeEasy;

public class ValidParentheseTask
{
    public static bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();
        
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char c in s)
        {
            if (bracketPairs.ContainsKey(c)) 
            {
                stack.Push(c);
            }
            else 
            {
                if (stack.Count == 0 || bracketPairs[stack.Pop()] != c)
                    return false;
            }
        }

        return stack.Count == 0; 
    }
}
//https://leetcode.com/problems/valid-parentheses/