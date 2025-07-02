namespace LeetCodeEasy;

public class CountOddNumbersInAnIntervalRangeTask
{
    public static int CountOdds(int low, int high)
    {
        
        int totalNumbers = high - low + 1;
    
        if (totalNumbers % 2 == 0)
        {
            return totalNumbers / 2;
        }
        else
        {
            return (low % 2 != 0) ? (totalNumbers / 2 + 1) : (totalNumbers / 2);
        }
    }
}
//https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/