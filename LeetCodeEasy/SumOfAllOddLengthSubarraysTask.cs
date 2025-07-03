namespace LeetCodeEasy;

public class SumOfAllOddLengthSubarraysTask
{
    public static int SumOddLengthSubarrays(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++) 
        {
            for (int l = 1; i + l <= arr.Length; l += 2) 
            {
                for (int j = i; j < i + l; j++) 
                {
                    result += arr[j];
                }
            }
        }
        return result;
    }
}
//https://leetcode.com/problems/sum-of-all-odd-length-subarrays/description/