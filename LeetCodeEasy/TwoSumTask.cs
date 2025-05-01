namespace LeetCodeEasy;

public class TwoSumTask
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var firstIndex = 0;
        var secondIndex = 0;

        while (secondIndex == 0)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[firstIndex] + nums[i] == target && i != firstIndex)
                {
                    secondIndex = i;
                }
            }

            if (secondIndex == 0)
            {
                firstIndex++;
            }
            else
            {
                break;
            }

        }
        
        return new int[] {firstIndex, secondIndex};
    }
}
//https://leetcode.com/problems/two-sum/description/