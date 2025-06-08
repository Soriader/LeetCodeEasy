namespace LeetCodeEasy;

public class LargestNumberAtLeastTwiceOfOthersTask
{
    public static int DominantIndex(int[] nums) 
    {
        var maxValue = nums.Max();
        var withoutMaxNum = nums.Where(x => x != maxValue).ToArray();
        
        if (withoutMaxNum.All(x => maxValue >= 2 * x))
        {
            return Array.IndexOf(nums, maxValue);
        }

        return -1;
    }
}
//https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/