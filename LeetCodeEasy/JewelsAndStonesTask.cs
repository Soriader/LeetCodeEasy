namespace LeetCodeEasy;

public class JewelsAndStonesTask
{
    public static int NumJewelsInStones(string jewels, string stones) 
    {
     
        var jewelsList = jewels.ToCharArray();
        var result = 0;

        foreach (var jew in stones.ToCharArray())
        {
            if (jewelsList.Contains(jew))
            {
                result++;
            }
        }
        return result;
    }
}
//https://leetcode.com/problems/jewels-and-stones/description/