namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class ThreeConsecutiveOddsTest
{
    [Test]
    public void ThreeConsecutiveOdds()
    {
        Assert.AreEqual(false, ThreeConsecutiveOddsTask.ThreeConsecutiveOdds(new int[]{2,6,4,1}));
        Assert.AreEqual(true, ThreeConsecutiveOddsTask.ThreeConsecutiveOdds(new int[]{1,2,34,3,4,5,7,23,12}));

    }
}