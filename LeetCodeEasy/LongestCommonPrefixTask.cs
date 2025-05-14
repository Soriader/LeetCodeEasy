namespace LeetCodeEasy;

public class LongestCommonPrefixTask
{
    public static string LongestCommonPrefix(string[] strs)
    {

        if (strs.Length == 1)
        {
            return strs[0];
        }
        
        string theShortestWord = strs.MinBy(s => s.Length); 
        string result = "";
        var boxForPrefix = "";
        
        for (int i = 0; i < theShortestWord.Length; i++)
        {
            bool allCorrect = strs.All(s => s.Length > i && s[i] == theShortestWord[i]);

            if (allCorrect)
            {
                boxForPrefix += theShortestWord[i];
                
                if (boxForPrefix.Length > result.Length)
                {
                    result = boxForPrefix;
                }
            }

            if (!allCorrect)
            {
                break;
            }
            
        }
        
        return result;
    }
}
//https://leetcode.com/problems/longest-common-prefix/description/