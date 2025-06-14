namespace LeetCodeEasy;

public class GoatLatinTask
{
    public static string ToGoatLatin(string sentence) 
    {
        var vovels = "aeiouAEIOU";
        var prtsOFSentence = sentence.Split(' ');
        var addA = "a";
        string result = "";

        foreach (var word in prtsOFSentence)
        {
            if (vovels.Contains(word[0]))
            {
                result += word + "ma" + addA + " ";
            }
            else if (word.Length == 0) 
            {
            } 
            else if (word.Length == 1) 
            {
                result += word + "ma" + addA + " ";
            } 
            else 
            {
                result += word.Substring(1) + word[0] + "ma" + addA + " ";
            }
            
            addA += "a";
        }

        return result.TrimEnd(' ');
    }
}
//https://leetcode.com/problems/goat-latin/description/