namespace LeetCodeEasy;

public class FindLuckyIntegerInAnArrayTask
{
    public static int FindLucky(int[] arr) 
    {
        
        var countAllNumbers = new Dictionary<int, int>();
    
        foreach (var number in arr)
        {
            countAllNumbers[number] = countAllNumbers.TryGetValue(number, out int count) ? count + 1 : 1;
        }

        int result = -1;
    
        foreach (var (number, count) in countAllNumbers)
        {
            if (number == count && number > result)
            {
                result = number;
            }
        }

        return result;
    }
}
//https://leetcode.com/problems/find-lucky-integer-in-an-array/?envType=daily-question&envId=2025-07-05