namespace LeetCodeEasy;

public class BestTimeToBuyAndSellStockTask
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length < 2)
        {
            return 0;
        }
        
        int min = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                int currentProfit = prices[i] - min;
                
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
            }
        }
        
        return maxProfit;

    }
}
//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/