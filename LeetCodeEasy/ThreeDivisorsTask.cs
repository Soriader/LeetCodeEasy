namespace LeetCodeEasy;

public class ThreeDivisorsTask
{
    public static bool IsThree(int n)
    {
        int p = (int)Math.Sqrt(n);
    
        if (p * p != n)
        {
            return false;
        }   
        
        return IsPrime(p);
    }

    private static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }        
        if (num == 2)
        {
            return true;
        }   
        if (num % 2 == 0)
        {
            return false;
        }    
        
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
            
        }
        
        return true;
    }
}
//https://leetcode.com/problems/three-divisors/