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
//https://leetcode.com/problems/longest-nice-substring/