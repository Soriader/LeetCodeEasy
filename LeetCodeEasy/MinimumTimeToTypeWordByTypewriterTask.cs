namespace LeetCodeEasy;

public class MinimumTimeToTypeWordByTypewriterTask
{
    public static Dictionary<char, int> alphabet = new Dictionary<char, int>
    {
        {'a', 0}, {'b', 1}, {'c', 2}, {'d', 3}, {'e', 4},
        {'f', 5}, {'g', 6}, {'h', 7}, {'i', 8}, {'j', 9},
        {'k', 10}, {'l', 11}, {'m', 12}, {'n', 13}, {'o', 14},
        {'p', 15}, {'q', 16}, {'r', 17}, {'s', 18}, {'t', 19},
        {'u', 20}, {'v', 21}, {'w', 22}, {'x', 23}, {'y', 24}, {'z', 25}
    };
    
    public static int MinTimeToType(string word)
    {
        int result = 0;
        int currentPosition = 0;

        foreach (char letter in word)
        {
            int targetPosition = letter - 'a';
            int clockwise = Math.Abs(targetPosition - currentPosition);
            int counterClockwise = 26 - clockwise;
            result += Math.Min(clockwise, counterClockwise) + 1;
            currentPosition = targetPosition;
        }

        return result;
    }
}
//https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/description/
