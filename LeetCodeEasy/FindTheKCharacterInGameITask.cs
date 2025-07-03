namespace LeetCodeEasy;

public class FindTheKCharacterInGameITask
{
    public static char KthCharacter(int k)
    {
        if (k == 1)
        {
            return 'a';
        }
        
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        var result = "ab";
        while (result.Length < k)
        {
            var nextPart = "";
            foreach (var letter in result)
            {
                int nextIndex = (alphabet.IndexOf(letter) + 1) % 26;
                nextPart += alphabet[nextIndex];
            }

            result += nextPart;
        }

        return result[k - 1];
    }
}
//https://leetcode.com/problems/find-the-k-th-character-in-string-game-i/?envType=daily-question&envId=2025-07-03