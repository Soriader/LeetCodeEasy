namespace LeetCodeEasy;

public class ReverseStringTask
{
    public static void ReverseString(char[] s)
    {
        char[] toReverse = new char[s.Length];
        Array.Copy(s, toReverse, s.Length);
    
        int iterator = 0;
        for (int i = toReverse.Length - 1; i >= 0; i--)
        {
            s[iterator] = toReverse[i];
            iterator++;
        }
    }
}
//https://leetcode.com/problems/power-of-four/description/