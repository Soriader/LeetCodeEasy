namespace LeetCodeEasy;

public class LongestNiceSubstringTask
{
    public static string LongestNiceSubstring(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string substring = s.Substring(i, j - i);
                if (IsNice(substring) && substring.Length > result.Length)
                {
                    result = substring;
                }
            }
        }

        return result;
    }

    private static bool IsNice(string s)
    {
        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                if (!s.Contains(char.ToLower(c)))
                {
                    return false;
                }
            }
            else
            {
                if (!s.Contains(char.ToUpper(c)))
                {
                    return false;
                }
            }
        }
        return true;
    }
}

/*Input: s = "YazaAay"
Output: "aAa"*/


//https://leetcode.com/problems/longest-nice-substring/

/*public static string LongestNiceSubstring(string s) 
{
    if (s.Length == 1)
    {
        return "";
    }
        
    string result = "";
    var boxForResult = "";
    var lastElement = s.Last();
        
    foreach (var letter in s)
    {
        if (boxForResult.Length >= 1 
            && char.IsUpper(letter)
            && boxForResult.LastOrDefault(x => char.IsLower(x)) == char.ToLower(letter)) 
        {
            boxForResult += letter;
        }
        else if (boxForResult.Length >= 1                 
                 && char.IsLower(letter) 
                 && boxForResult.LastOrDefault(x => char.IsUpper(x)) == char.ToUpper(letter))
        {
            boxForResult += letter;
        }

        if (boxForResult == "" 
            || boxForResult.LastOrDefault(x => char.IsUpper(x)) != char.ToUpper(letter)
            || boxForResult.LastOrDefault(x => char.IsLower(x)) != char.ToLower(letter)
            || letter == lastElement)
        {
            boxForResult = "";
            boxForResult += letter;
        }
            
            
    }
        
    return result;
}*/