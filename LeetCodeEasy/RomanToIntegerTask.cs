namespace LeetCodeEasy;

public class RomanToIntegerTask
{
    private static Dictionary<char, int> romanToNumber = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    
    public static int RomanToInt(string s) 
    {
        int result = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            int currentVal = romanToNumber[s[i]];
            
            if (i < s.Length - 1 && currentVal < romanToNumber[s[i + 1]])
            {
                result -= currentVal; 
            }
            else
            {
                result += currentVal;
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/roman-to-integer/