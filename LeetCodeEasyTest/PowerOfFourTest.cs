namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class PowerOfFourTest
{
    [Test]
    public void PowerOfFour()
    {
        Assert.AreEqual(true, PowerOfFourTask.IsPowerOfFour(16));
        Assert.AreEqual(true, PowerOfFourTask.IsPowerOfFour(1));
        Assert.AreEqual(false, PowerOfFourTask.IsPowerOfFour(5));
        Assert.AreEqual(false, PowerOfFourTask.IsPowerOfFour(1162261466));
    }
}