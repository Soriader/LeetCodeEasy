namespace LeetCodeEasy;

public class MakeTwoArraysEqualByReversingSubarraysTask
{
    public bool CanBeEqual(int[] target, int[] arr) 
    {
        return arr.OrderBy(x => x).SequenceEqual(target.OrderBy(x => x));
    }
}
//https://leetcode.com/problems/make-two-arrays-equal-by-reversing-subarrays/