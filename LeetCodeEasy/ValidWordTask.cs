namespace LeetCodeEasy;

public class ValidWordTask
{
    public static bool IsValid(string word) 
    {
        if(IsCorrectLength(word) 
           && IsLetterOrDigit(word)
           && IsContainsAVovel(word)
           && IsContainsAConsonant(word))
        {
            return true;
        }

        return false;
    }

    private static bool IsCorrectLength(string word)
    {
        return word.Length >= 3;
    }

    private static bool IsLetterOrDigit(string word)
    {
        foreach (char c in word)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }
        }
        
        return true;
    }

    private static bool IsContainsAVovel(string word)
    {
        var vovels = "aeiouAEIOU";
        
        foreach (var c in word)
        {
            if (vovels.Contains(c.ToString()))
            {
                return true;
            }
        }
        
        return false;
    }
    
    private static bool IsContainsAConsonant(string word)
    {
        foreach (var c in word)
        {
            if (char.IsLetter(c) && !IsContainsAVovel(c.ToString()))
            {
                return true;
            }
        }
        
        return false;
    }
}
//https://leetcode.com/problems/valid-word/description/?envType=daily-question&envId=2025-07-15