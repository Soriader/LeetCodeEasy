namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class BestTimeToBuyAndSellStockTest
{
   [Test]
   public void BestTimeToBuyAndSellStock()
   {
      Assert.AreEqual(5, BestTimeToBuyAndSellStockTask.MaxProfit(new int[] { 7,1,5,3,6,4 }));
      Assert.AreEqual(0, BestTimeToBuyAndSellStockTask.MaxProfit(new int[] { 7,6,4,3,1 }));
      Assert.AreEqual(2, BestTimeToBuyAndSellStockTask.MaxProfit(new int[] { 2,4,1 }));
      Assert.AreEqual(1, BestTimeToBuyAndSellStockTask.MaxProfit(new int[] { 2,1,2,0,1 }));
   }
}