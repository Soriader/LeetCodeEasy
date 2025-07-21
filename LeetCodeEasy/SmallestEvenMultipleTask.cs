namespace LeetCodeEasy;

public class SmallestEvenMultipleTask
{
    public static int SmallestEvenMultiple(int n) 
    {
        if (n % 2 == 0)
        {
            return n;
        }
        else
        {
            return n * 2;
        }
    }
}
//https://leetcode.com/problems/smallest-even-multiple/description/