namespace LeetCodeEasy;

public class LengthOfLastWordTask
{
    public static int LengthOfLastWord(string s) 
    {
        return s.TrimEnd().Split(' ').Last().Length;
    }
}
//https://leetcode.com/problems/length-of-last-word/description/