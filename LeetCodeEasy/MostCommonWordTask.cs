namespace LeetCodeEasy;

public class MostCommonWordTask
{
    public static string MostCommonWord(string paragraph, string[] banned) 
    {
        string check = new string(paragraph
            .ToLower()
            .Select(c => char.IsLetter(c) ? c : ' ')
            .ToArray());

        string[] words = check.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        var countBox = new Dictionary<string, int>();
        var bannedLower = banned.Select(b => b.ToLower()).ToArray();

        foreach (var word in words)
        {
            if (bannedLower.Contains(word))
            {
                continue;
            }
            if (countBox.ContainsKey(word))
            {
                countBox[word]++;
            }
            else
            {
                countBox[word] = 1;
            }        
        }

        return countBox.OrderByDescending(p => p.Value).First().Key;
    }

}
//https://leetcode.com/problems/most-common-word/description/