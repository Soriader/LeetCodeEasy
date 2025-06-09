namespace LeetCodeEasy;

public class FinalPricesWithASpecialDiscountInAShopTask
{
    public static int[] FinalPrices(int[] prices)
    {
        int[] result = new int[prices.Length];
    
        for (int i = 0; i < prices.Length; i++)
        {
            result[i] = prices[i];
        
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    result[i] = prices[i] - prices[j];
                    break;
                }
            }
        }
    
        return result;
    }
}
//https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/description/