using System.Text;

namespace LeetCodeEasy;

public class AddStringsTask
{
    public static string AddStrings(string num1, string num2) 
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;
        StringBuilder result = new StringBuilder();
    
        while (i >= 0 || j >= 0 || carry > 0) 
        {
            int digit1 = i >= 0 ? num1[i--] - '0' : 0;
            int digit2 = j >= 0 ? num2[j--] - '0' : 0;
            int sum = digit1 + digit2 + carry;
            carry = sum / 10;
            result.Append(sum % 10);
        }
    
        var charArray = result.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
//https://leetcode.com/problems/add-strings/description/