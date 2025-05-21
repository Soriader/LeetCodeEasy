namespace LeetCodeEasy;

public class SingleNumberTask
{
    public static int SingleNumber(int[] nums) 
    {
        var checkTheIntensity = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (checkTheIntensity.ContainsKey(num))
            {
                checkTheIntensity[num]++;
            }
            else
            {
                checkTheIntensity.Add(num, 1);
            }
        }
        
        return checkTheIntensity.FirstOrDefault(x => x.Value == 1).Key;
    }
}
//https://leetcode.com/problems/single-number/description/