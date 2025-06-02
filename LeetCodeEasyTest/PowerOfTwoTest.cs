namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class PowerOfTwoTest
{
    [Test]
    public void PowerOfTwo()
    {
        Assert.AreEqual(true, PowerOfTwoTask.IsPowerOfTwo(1));
        Assert.AreEqual(true, PowerOfTwoTask.IsPowerOfTwo(16));
        Assert.AreEqual(true, PowerOfTwoTask.IsPowerOfTwo(536870912));
        Assert.AreEqual(false, PowerOfTwoTask.IsPowerOfTwo(3));
    }
}