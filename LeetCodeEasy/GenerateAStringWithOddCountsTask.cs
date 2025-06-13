namespace LeetCodeEasy;

public class GenerateAStringWithOddCountsTask
{
    public static string GenerateTheString(int n) 
    {
        if (n % 2 == 1)  
        {
            return string.Concat(Enumerable.Repeat("a", n));
        }
        else  
        {
            return string.Concat(Enumerable.Repeat("a", n - 1)) + "b";
        }
    }
}
//https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/description/