namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class FinalPricesWithASpecialDiscountInAShopTest
{
    [Test]
    public void FinalPricesWithASpecialDiscountInAShop()
    {
        var input = new int[] { 8, 4, 6, 2, 3 };
        var expected = new int[] { 4,2,4,2,3 };
        Assert.AreEqual(expected, FinalPricesWithASpecialDiscountInAShopTask.FinalPrices(input));
    }
    
}