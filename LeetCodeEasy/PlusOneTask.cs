namespace LeetCodeEasy;

public class PlusOneTask
{
    public static int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
        
            digits[i] = 0;
        }
        
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        
        return result;
    }
}
//https://leetcode.com/problems/plus-one/description/

//This result is still ok but not for numbers which have more value than inr properties
/*public static int[] PlusOne(int[] digits)
{
    var boxForNumber = "";
    foreach (int i in digits)
    {
        boxForNumber += i.ToString();
    }
        
    var numbers = (int.Parse(boxForNumber) + 1).ToString().ToCharArray();

    var result = new List<int>();
        
    foreach (char c in numbers)
    {
        result.Add(int.Parse(c.ToString()));
    }
        
    return result.ToArray();
}*/

