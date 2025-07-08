namespace LeetCodeEasy;

public class FindClosestNumberToZeroTask
{
    public static int FindClosestNumber(int[] nums)
    {
        int result = nums[0];
        
        foreach (var num in nums)
        {
            if (Math.Abs(num) < Math.Abs(result))
            {
                result = num;
            }
            else if (Math.Abs(num) == Math.Abs(result) && num > result)
            {
                result = num;
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/find-closest-number-to-zero/description/