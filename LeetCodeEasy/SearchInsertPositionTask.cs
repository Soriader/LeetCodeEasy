namespace LeetCodeEasy;

public class SearchInsertPositionTask
{
    public static int SearchInsert(int[] nums, int target) 
    {
        if (nums.Contains(target))
        {
            return Array.IndexOf(nums, target);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < target 
                && i != nums.Length - 1
                && nums[i + 1] > target 
                || i == nums.Length - 1 && nums[i] < target
                )
            {
                return i + 1;
            }

        }
        
        return 0;
    }
}
//https://leetcode.com/problems/search-insert-position/description/