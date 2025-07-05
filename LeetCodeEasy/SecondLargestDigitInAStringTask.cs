namespace LeetCodeEasy;

public class SecondLargestDigitInAStringTask
{
    public static int SecondHighest(string s) 
    {
        List<int> digits = new List<int>();
        
        foreach (var num in s)
        {
            if (char.IsDigit(num) && !digits.Contains(num - '0'))
            {
                digits.Add(num - '0');
            }
        }
        
        if (digits.Count < 2)
        {
            return -1;
        }
        
        return digits.OrderByDescending(d => d).Skip(1).First();
    }
}
//https://leetcode.com/problems/second-largest-digit-in-a-string/description/