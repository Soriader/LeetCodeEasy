namespace LeetCodeEasy;

public class PowerOfFourTask
{
    public static bool IsPowerOfFour(int n)
    {
        if (n <= 0)
        {
            return false;
        }
    
        double log = Math.Log(n, 4);
        return log == Math.Floor(log);
    }
}
//https://leetcode.com/problems/power-of-four/description/