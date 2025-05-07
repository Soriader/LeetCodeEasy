namespace LeetCodeEasy;

public class RemoveElementTask
{
    public static int RemoveElement(int[] nums, int val)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[result] = nums[i];
                result++;
            }
        }
        return result;
        
    }
    //https://leetcode.com/problems/remove-element/description/
}