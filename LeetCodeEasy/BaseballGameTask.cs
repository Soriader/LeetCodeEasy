namespace LeetCodeEasy;

public class BaseballGameTask
{
    private static readonly Dictionary<char, Action<List<int>>> optionsForResult = new Dictionary<char, Action<List<int>>>
    {
        {'+', (scores) => {
            if (scores.Count >= 2)
            {
                int newScore = scores[scores.Count - 1] + scores[scores.Count - 2];
                scores.Add(newScore);
            }
        }},
        {'D', (scores) => {
            if (scores.Count >= 1)
            {
                int newScore = scores[scores.Count - 1] * 2;
                scores.Add(newScore);
            }
        }},
        {'C', (scores) => {
            if (scores.Count >= 1)
            {
                scores.RemoveAt(scores.Count - 1);
            }
        }}
    };
    
    public static int CalPoints(string[] operations) 
    {
        var boxForResult = new List<int>();
        
        foreach (string op in operations)
        {
            if (int.TryParse(op, out int number))
            {
                boxForResult.Add(number);
            }
            else if (op.Length == 1 && optionsForResult.ContainsKey(op[0]))
            {
                optionsForResult[op[0]](boxForResult);
            }
        }
        
        return boxForResult.Sum();
    }
}
//https://leetcode.com/problems/baseball-game/description/