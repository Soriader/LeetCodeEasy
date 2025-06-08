namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class LargestNumberAtLeastTwiceOfOthersTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(-1, LargestNumberAtLeastTwiceOfOthersTask.DominantIndex(new int[]{1,2,3,4}));
        Assert.AreEqual(1, LargestNumberAtLeastTwiceOfOthersTask.DominantIndex(new int[]{3,6,1,0}));
    }
}