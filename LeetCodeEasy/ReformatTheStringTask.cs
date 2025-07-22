using System.Text;

namespace LeetCodeEasy;

public class ReformatTheStringTask
{
    public string Reformat(string s)
    {
        var letters = new List<char>();
        var digits = new List<char>();

        foreach (var c in s)
        {
            if (char.IsLetter(c))
            {
                letters.Add(c);
            }
            else
            {
                digits.Add(c);
            }
        }

        if (Math.Abs(letters.Count - digits.Count) > 1)
        {
            return "";
        }
        
        var result = new StringBuilder();
        bool startWithLetter = letters.Count > digits.Count;

        for (int i = 0; i < Math.Min(letters.Count, digits.Count); i++)
        {
            if (startWithLetter)
            {
                result.Append(letters[i]).Append(digits[i]);
            }            
            else
            {
                result.Append(digits[i]).Append(letters[i]);
            }
            
        }

        if (letters.Count > digits.Count)
        {
            result.Append(letters.Last());
        }       
        else if (digits.Count > letters.Count)
        {
            result.Append(digits.Last());
        }
        return result.ToString();
    }
}
//https://leetcode.com/problems/reformat-the-string/