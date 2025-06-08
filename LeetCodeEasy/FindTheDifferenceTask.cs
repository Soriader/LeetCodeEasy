namespace LeetCodeEasy;

public class FindTheDifferenceTask
{
    public static char FindTheDifference(string s, string t)
    {
        var sCount = s
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());
        
        var tCount = t
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        foreach (var kvp in tCount)
        {
            if (!sCount.ContainsKey(kvp.Key))
            {
                return kvp.Key;
            }
        }

        foreach (var kvp in sCount)
        {
            if (tCount[kvp.Key] > kvp.Value)
            {
                return kvp.Key;
            }
        }

        return t[0];
    }
}
//https://leetcode.com/problems/find-the-difference/description/