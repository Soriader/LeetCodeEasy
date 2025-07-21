namespace LeetCodeEasy;

public class FindSubarraysWithEqualSumTask
{
    public static bool FindSubarrays(int[] nums) 
    {
        var sums = new List<int>();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            var sum = nums[i] + nums[i + 1];

            if (sums.Contains(sum))
            {
                return true;
            }
            else
            {
                sums.Add(sum);
            }
        }
        
        return false;
    }
}
//https://leetcode.com/problems/find-subarrays-with-equal-sum/