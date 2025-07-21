using System.Text;

namespace LeetCodeEasy;

public class DeleteCharactersToMakeFancyStringTask
{
    public static string MakeFancyString(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }
        
        StringBuilder result = new StringBuilder();
        int iterator = 1;
        result.Append(s[0]);

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                iterator++;
            }
            else
            {
                iterator = 1;
            }

            if (iterator < 3)
            {
                result.Append(s[i]);
            }
        }

        return result.ToString();
    }
}
//https://leetcode.com/problems/delete-characters-to-make-fancy-string/?envType=daily-question&envId=2025-07-21