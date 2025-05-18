namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class SqrtXTest
{
    [Test]
    public void SqrtX()
    {
        Assert.AreEqual(2, SqrtXTask.MySqrt(4));
        Assert.AreEqual(2, SqrtXTask.MySqrt(8));
    }
}