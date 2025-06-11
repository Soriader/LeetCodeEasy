namespace LeetCodeEasy;

public class FairCandySwapTask
{
    public static int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) 
    {
        var sumA = aliceSizes.Sum(); 
        var sumB = bobSizes.Sum();
        var result = new int[aliceSizes.Length];

        for (int i = 0; i < aliceSizes.Length; i++)
        {
            for (int j = 0; j < bobSizes.Length; j++)
            {
                if (sumA - sumB == 2*(aliceSizes[i] - bobSizes[j]))
                {
                    result =[aliceSizes[i], bobSizes[j]]; 
                }
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/fair-candy-swap/description/