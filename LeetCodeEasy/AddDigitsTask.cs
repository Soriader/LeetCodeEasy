namespace LeetCodeEasy;

public class AddDigitsTask
{
    public static int AddDigits(int num) 
    {
        while (num >= 10)
        {
            num = num.ToString().Sum(c => (int)Char.GetNumericValue(c));
        }
        return num;    
    }
}
//https://leetcode.com/problems/add-digits/description/