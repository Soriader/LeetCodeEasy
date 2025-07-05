namespace LeetCodeEasy;

public class CheckIfStringIsAPrefixOfArrayTask
{
    public static bool IsPrefixString(string s, string[] words)
    {
        var currentLength = 0;
        var actualString = "";
        foreach (var word in words)
        {
            currentLength += word.Length;
            actualString += word;
            
            if (currentLength == s.Length && actualString == s)
            {
                return true;
            }
        }
        
        return false;
    }
}
//https://leetcode.com/problems/check-if-string-is-a-prefix-of-array/description/