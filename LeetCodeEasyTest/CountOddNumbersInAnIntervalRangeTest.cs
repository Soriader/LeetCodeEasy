namespace LeetCodeEasyTest;

public class CountOddNumbersInAnIntervalRangeTest
{
    [Test]
    public void CountOddNumbersInAnIntervalRange()
    {
        Assert.AreEqual(3, CountOddNumbersInAnIntervalRangeTask.CountOdds(3, 7));
        Assert.AreEqual(1, CountOddNumbersInAnIntervalRangeTask.CountOdds(8, 10));
    }
}