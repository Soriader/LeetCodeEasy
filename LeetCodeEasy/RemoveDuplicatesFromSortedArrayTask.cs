﻿namespace LeetCodeEasy;

public class RemoveDuplicatesFromSortedArrayTask
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        
        int k = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;

    }
}
//https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/