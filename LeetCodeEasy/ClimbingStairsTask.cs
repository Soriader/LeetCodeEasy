namespace LeetCodeEasy;

public class ClimbingStairsTask
{
    public static int ClimbStairs(int n)
    {
        if (n == 1)
        {
            return 1;
        }
    
        int first = 1; 
        int second = 2; 
    
        for (int i = 3; i <= n; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }
    
        return second;
    }
}
//https://leetcode.com/problems/climbing-stairs/