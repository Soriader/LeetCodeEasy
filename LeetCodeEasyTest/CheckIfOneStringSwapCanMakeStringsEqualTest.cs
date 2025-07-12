namespace LeetCodeEasyTest;

public class CheckIfOneStringSwapCanMakeStringsEqualTest
{
    [Test]
    public void CheckIfOneStringSwapCanMakeStringsEqual()
    {
     
        Assert.AreEqual(true, CheckIfOneStringSwapCanMakeStringsEqualTask.AreAlmostEqual("bank", "kanb"));
        Assert.AreEqual(true, CheckIfOneStringSwapCanMakeStringsEqualTask.AreAlmostEqual("kelb", "kelb"));
        Assert.AreEqual(false, CheckIfOneStringSwapCanMakeStringsEqualTask.AreAlmostEqual("attack", "defend"));
        
    }
}