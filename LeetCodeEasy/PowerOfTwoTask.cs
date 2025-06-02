namespace LeetCodeEasy;

public class PowerOfTwoTask
{
    public static bool IsPowerOfTwo(int n) 
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
}
//https://leetcode.com/problems/power-of-two/submissions/1651771903/