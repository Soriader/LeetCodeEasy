namespace LeetCodeEasyTest;

public class ThreeDivisorsTest
{
    [Test]
    public void ThreeDivisors()
    {
        Assert.AreEqual(true, ThreeDivisorsTask.IsThree(4));
        Assert.AreEqual(true, ThreeDivisorsTask.IsThree(529));
        Assert.AreEqual(true, ThreeDivisorsTask.IsThree(961));
        Assert.AreEqual(true, ThreeDivisorsTask.IsThree(49));
        Assert.AreEqual(false, ThreeDivisorsTask.IsThree(2));
        Assert.AreEqual(false, ThreeDivisorsTask.IsThree(50));
        Assert.AreEqual(false, ThreeDivisorsTask.IsThree(962));
    }
}