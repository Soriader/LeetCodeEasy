namespace LeetCodeEasy;

public class SplitAStringInBalancedStringsTask
{
    public static int BalancedStringSplit(string s)
    {
        int balance = 0;
        int result = 0;

        foreach (var letter in s)
        {
            if (letter == 'R')
            {
                balance++;
            }
            else if (letter == 'L')
            {
                balance--;
            }

            if (balance == 0)
            {
                result++;
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/split-a-string-in-balanced-strings/description/