namespace LeetCodeEasyTest;

public class MinimumValueToGetPositiveStepByStepSumTest
{
    [Test]
    public void MinimumValueToGetPositiveStepByStepSum()
    {
        Assert.AreEqual(5, MinimumValueToGetPositiveStepByStepSumTask.MinStartValue(new int[]{-3,2,-3,4,2}));
        Assert.AreEqual(1, MinimumValueToGetPositiveStepByStepSumTask.MinStartValue(new int[]{1,2}));
        Assert.AreEqual(5, MinimumValueToGetPositiveStepByStepSumTask.MinStartValue(new int[]{1,-2,-3}));
    }
}