namespace LeetCodeEasyTest;

public class FindClosestNumberToZeroTest
{
    [Test]
    public void FindClosestNumberToZero()
    {
        Assert.AreEqual(1, FindClosestNumberToZeroTask.FindClosestNumber(new int[]{-4,-2,1,4,8}));
        Assert.AreEqual(1, FindClosestNumberToZeroTask.FindClosestNumber(new int[]{2,-1,1}));
    }
}