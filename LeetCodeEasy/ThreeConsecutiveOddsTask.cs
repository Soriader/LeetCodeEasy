namespace LeetCodeEasy;

public class ThreeConsecutiveOddsTask
{
    public static bool ThreeConsecutiveOdds(int[] arr) 
    {
        int consecutiveOdds = 0;
    
        foreach (int num in arr)
        {
            if (num % 2 != 0)
            {
                consecutiveOdds++;
                if (consecutiveOdds == 3)
                {
                    return true;
                }
            }
            else
            {
                consecutiveOdds = 0;
            }
        }
    
        return false;
    }
}
//https://leetcode.com/problems/three-consecutive-odds/description/?envType=daily-question&envId=2025-05-11