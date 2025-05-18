using System.Text;

namespace LeetCodeEasy;

public class AddBinaryTask
{
    public static string AddBinary(string a, string b) 
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder result = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digitA = (i >= 0) ? a[i--] - '0' : 0;
            int digitB = (j >= 0) ? b[j--] - '0' : 0;
        
            int sum = digitA + digitB + carry;
            result.Insert(0, sum % 2); 
            carry = sum / 2;
        }

        return result.ToString();
    }
}
//https://leetcode.com/problems/add-binary/description/