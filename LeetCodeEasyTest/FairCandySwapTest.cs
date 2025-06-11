namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class FairCandySwapTest
{

    [Test]
    public void FairCandySwap()
    {
        Assert.AreEqual(new int[]{1,2}, FairCandySwapTask.FairCandySwap(new int[]{1,1}, new int[]{2,2}));
    }
    
}