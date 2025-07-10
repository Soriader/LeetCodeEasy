using System.Text;

namespace LeetCodeEasy;

public class NumberOfDifferentIntegersInAStringTask
{
    public static int NumDifferentIntegers(string word) 
    {
        var result = new List<string>();
        var currentNumber = new StringBuilder();
        
        foreach (char c in word)
        {
            if (char.IsDigit(c))
            {
                currentNumber.Append(c); 
            }
            else if (currentNumber.Length > 0)
            {
                string trimmedNumber = TrimLeadingZeros(currentNumber.ToString());
                
                if (!ContainsNumber(result, trimmedNumber))
                {
                    result.Add(trimmedNumber);
                }
                
                currentNumber.Clear(); 
            }
        }
        
        if (currentNumber.Length > 0)
        {
            string trimmedNumber = TrimLeadingZeros(currentNumber.ToString());
            if (!ContainsNumber(result, trimmedNumber))
            {
                result.Add(trimmedNumber);
            }
        }
        
        return result.Count;
    }
    
    private static string TrimLeadingZeros(string numStr)
    {
        int i = 0;
        
        while (i < numStr.Length - 1 && numStr[i] == '0') 
        {
            i++;
        }
        
        return numStr.Substring(i);
    }
    
    private static bool ContainsNumber(List<string> numbers, string numStr)
    {
        foreach (string num in numbers)
        {
            if (num == numStr)
            {
                return true;
            }
        }
        return false;
    }
}
//https://leetcode.com/problems/number-of-different-integers-in-a-string/description/