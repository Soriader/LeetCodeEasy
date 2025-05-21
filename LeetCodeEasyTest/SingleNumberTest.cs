namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class SingleNumberTest
{
    [Test]
    public void SingleNumberCheck()
    {
        Assert.AreEqual(1, SingleNumberTask.SingleNumber(new int[] { 2,2,1 }));
        Assert.AreEqual(4, SingleNumberTask.SingleNumber(new int[] { 4,1,2,1,2 }));
        Assert.AreEqual(1, SingleNumberTask.SingleNumber(new int[] { 1 }));

    }
}