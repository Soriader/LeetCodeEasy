namespace LeetCodeEasyTest;

public class KthMissingPositiveNumberTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(9, KthMissingPositiveNumberTask.FindKthPositive(new int[]{2,3,4,7,11}, 5));
        Assert.AreEqual(6, KthMissingPositiveNumberTask.FindKthPositive(new int[]{1,2,3,4}, 2));
    }
}