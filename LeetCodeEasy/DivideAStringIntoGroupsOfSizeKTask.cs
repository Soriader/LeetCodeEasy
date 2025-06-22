namespace LeetCodeEasy;

public class DivideAStringIntoGroupsOfSizeKTask
{
    public static string[] DivideString(string s, int k, char fill) 
    {
        if (s is null)
        {
            return null;
        }
        
        var result = new List<string>();
        var part = "";

        for (int i = 0; i < s.Length; i++)
        {
            part += s[i];
            
            if (part.Length == k)
            {
                result.Add(part);
                part = "";
            }
            else if (i == s.Length - 1 && part.Length != k)
            {
                part += String.Concat(Enumerable.Repeat($"{fill}", k - part.Length));
                result.Add(part);
                break;
            }
        }
        
        
        return result.ToArray();
    }
}
//https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/description/?envType=daily-question&envId=2025-06-22