namespace LeetCodeEasy;

public class TeemoAttackingTask
{
    public static int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if (timeSeries.Length == 0 || duration == 0)
        {
            return 0;
        }   
        
        int secondOfPoisonedDamage = 0;
        
        int durationEnd = timeSeries[0] + duration;
    
        secondOfPoisonedDamage += duration;
    
        for (int i = 1; i < timeSeries.Length; i++) 
        {
            int currentStart = timeSeries[i];
            
            if (currentStart >= durationEnd) 
            {
                secondOfPoisonedDamage += duration;
            } 
            else 
            {
                secondOfPoisonedDamage += currentStart + duration - durationEnd;
            }
            durationEnd = currentStart + duration;
        }
    
        return secondOfPoisonedDamage;        
    }
}
//https://leetcode.com/problems/teemo-attacking/description/