namespace LeetCodeEasy;

public class LongestHarmoniousSubsequenceTask
{
    public static int FindLHS(int[] nums) 
    {
        var countTheNumbers = new Dictionary<int, int>();
        int result = 0;
        
        foreach (var num in nums)
        {
            if (countTheNumbers.ContainsKey(num))
            {
                countTheNumbers[num]++;
            }
            else
            {
                countTheNumbers.Add(num, 1);
            }
        }

        foreach (var num in countTheNumbers.Keys.ToList())
        {
            if (countTheNumbers.ContainsKey(num + 1))
            {
                int currentLength = countTheNumbers[num] + countTheNumbers[num + 1];
                if (currentLength > result)
                {
                    result = currentLength;
                }
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/longest-harmonious-subsequence/description/?envType=daily-question&envId=2025-06-30