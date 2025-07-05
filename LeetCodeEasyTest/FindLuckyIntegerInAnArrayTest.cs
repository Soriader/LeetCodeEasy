namespace LeetCodeEasyTest;

public class FindLuckyIntegerInAnArrayTest
{
    [Test]
    public void FindLuckyIntegerInAnArray()
    {
        Assert.AreEqual(2, FindLuckyIntegerInAnArrayTask.FindLucky(new int[]{2,2,3,4}));
        Assert.AreEqual(3, FindLuckyIntegerInAnArrayTask.FindLucky(new int[]{1,2,2,3,3,3}));
        Assert.AreEqual(-1, FindLuckyIntegerInAnArrayTask.FindLucky(new int[]{2,2,2,3,3}));
    }
}