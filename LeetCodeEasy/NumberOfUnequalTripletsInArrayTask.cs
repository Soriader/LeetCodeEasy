namespace LeetCodeEasy;

public class NumberOfUnequalTripletsInArrayTask
{
    public static int UnequalTriplets(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k]) 
                    {
                        result++;
                    }
                }
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/number-of-unequal-triplets-in-array/description/