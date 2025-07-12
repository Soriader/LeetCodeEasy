namespace LeetCodeEasy;

public class CheckIfOneStringSwapCanMakeStringsEqualTask
{
    public static bool AreAlmostEqual(string s1, string s2)
    {
        if (s1 == s2)
        {
            return true;
        }

        List<int> diffIndices = new List<int>();
    
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                diffIndices.Add(i);
            }   
            
            if (diffIndices.Count > 2)
            {
                return false;
            }        }
    
        return diffIndices.Count == 2 
               && s1[diffIndices[0]] == s2[diffIndices[1]] 
               && s1[diffIndices[1]] == s2[diffIndices[0]];

    }
    
}
//https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/