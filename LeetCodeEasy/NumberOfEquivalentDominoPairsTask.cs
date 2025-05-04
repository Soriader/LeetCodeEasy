namespace LeetCodeEasy;

public class NumberOfEquivalentDominoPairsTask
{
    public static int NumEquivDominoPairs(int[][] dominoes)
    {
        var sortedDominoes = dominoes
            .Select(d => d.OrderBy(x => x).ToArray())
            .Select(d => (d[0], d[1]))
            .ToList();

        var dominoCounts = new Dictionary<(int, int), int>();

        foreach (var domino in sortedDominoes)
        {
            if (dominoCounts.ContainsKey(domino))
            {
                dominoCounts[domino]++;
            }
            else
            {
                dominoCounts[domino] = 1;
            }        
        }

        int result = 0;
        foreach (var count in dominoCounts.Values)
        {
            if (count >= 2)
            {
                result += count * (count - 1) / 2;
            }
            
        }
        
        return result;
    }
}
//https://leetcode.com/problems/number-of-equivalent-domino-pairs/description/?envType=daily-question&envId=2025-05-04