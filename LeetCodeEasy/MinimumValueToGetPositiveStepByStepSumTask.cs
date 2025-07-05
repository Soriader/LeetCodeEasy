namespace LeetCodeEasy;

public class MinimumValueToGetPositiveStepByStepSumTask
{
    public static int MinStartValue(int[] nums) 
    { 
        int minSum = 0;
        int currentSum = 0;
    
        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
        
            if (currentSum < minSum)
            {
                minSum = currentSum;
            }
        }
    
        return Math.Max(1, 1 - minSum);
    }
}
//https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/description/