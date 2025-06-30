namespace LeetCodeEasyTest;

public class LastStoneWeightTest
{
    [Test]
    public void LastStone()
    {
        Assert.AreEqual(1, LastStoneWeightTask.LastStoneWeight(new int[] { 2,7,4,1,8,1}));
        Assert.AreEqual(1, LastStoneWeightTask.LastStoneWeight(new int[] {1}));
    }
}