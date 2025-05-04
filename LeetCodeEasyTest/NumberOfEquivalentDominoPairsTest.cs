namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class NumberOfEquivalentDominoPairsTest
{
    [Test]
    public void NumberOfEquivalentDominoPairs()
    {
        Assert.AreEqual(1, NumberOfEquivalentDominoPairsTask.NumEquivDominoPairs(new int[][]{[1,2],[2,1],[3,4],[5,6]}));
        Assert.AreEqual(3, NumberOfEquivalentDominoPairsTask.NumEquivDominoPairs(new int[][]{[1,2],[1,2],[1,1],[1,2],[2,2]}));
    }
}