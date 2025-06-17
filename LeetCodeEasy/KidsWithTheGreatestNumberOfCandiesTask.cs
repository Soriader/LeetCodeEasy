namespace LeetCodeEasy;

public class KidsWithTheGreatestNumberOfCandiesTask
{
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new List<bool>();

        for (int i = 0; i < candies.Length; i++)
        {
            int extraCandiesToAdd = extraCandies + candies[i];
            
            if (candies.All(x => x <= extraCandiesToAdd))
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/