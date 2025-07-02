namespace LeetCodeEasy;

public class FindTheOriginalTypedStringITask
{
    public static int PossibleStringCount(string word) 
    {
        var listForPartsOfWord = new List<string>();
        var boxForLetters = word[0].ToString();
        
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == boxForLetters[0])
            {
                boxForLetters += word[i];
            }
            else
            {
                listForPartsOfWord.Add(boxForLetters);
                boxForLetters = word[i].ToString();
            }
        }
        listForPartsOfWord.Add(boxForLetters);
        int result = 0;

        foreach (var partsOfWord in listForPartsOfWord)
        {
            result += partsOfWord.Length - 1;
        }

        return result;
    }
}
//https://leetcode.com/problems/find-the-original-typed-string-i/description/?envType=daily-question&envId=2025-07-01