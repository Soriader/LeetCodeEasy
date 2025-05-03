namespace LeetCodeEasy;

public class PalindromeNumberTask
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }   
        
        var checkThePalindrome = new string(x.ToString().Reverse().ToArray());
        
        return int.TryParse(checkThePalindrome, out int numberToCheck) && numberToCheck == x;
    }
}
//https://leetcode.com/problems/palindrome-number/description/