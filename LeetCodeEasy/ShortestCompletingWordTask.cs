namespace LeetCodeEasy;

public class ShortestCompletingWordTask
{
    public static string ShortestCompletingWord(string licensePlate, string[] words) 
    {
        var cleanedLicensePlate = new string(licensePlate
            .ToLower()
            .Where(c => char.IsLetter(c))
            .ToArray());
        var boxForResults = new List<string>();
        

        var licenseCounts = cleanedLicensePlate
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        foreach (var word in words)
        {
            var wordCounts = word
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            bool isValid = licenseCounts.All(kv => 
                wordCounts.ContainsKey(kv.Key) && 
                wordCounts[kv.Key] >= kv.Value);
    
            if (isValid)
            {
                boxForResults.Add(word);
            }
        }
        
        return boxForResults.OrderBy(word => word.Length).First();    
    }
}
//https://leetcode.com/problems/shortest-completing-word/description/