namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class PlusOneTest
{
    [Test]
    public void PlusOne()
    {
        Assert.AreEqual(new int[]{1,2,4}, PlusOneTask.PlusOne(new int[]{1,2,3}));
        Assert.AreEqual(new int[]{4,3,2,2}, PlusOneTask.PlusOne(new int[]{4,3,2,1}));
        Assert.AreEqual(new int[]{1,0}, PlusOneTask.PlusOne(new int[]{9}));
    }
}