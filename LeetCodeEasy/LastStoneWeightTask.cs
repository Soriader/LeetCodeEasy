namespace LeetCodeEasy;

public class LastStoneWeightTask
{
    public static int LastStoneWeight(int[] stones) 
    {
        var stonesList = stones.ToList();
        
        while (stonesList.Count > 1)
        {
            stonesList.Sort((a, b) => b.CompareTo(a));
            int y = stonesList[0];
            int x = stonesList[1];
    
            stonesList.RemoveAt(0); 
            stonesList.RemoveAt(0);
    
            if (x != y)
            {
                stonesList.Add(y - x);
            }
            
        }
        
        return stonesList.Count == 0 ? 0 : stonesList[0];
    }
}
//https://leetcode.com/problems/last-stone-weight/description/