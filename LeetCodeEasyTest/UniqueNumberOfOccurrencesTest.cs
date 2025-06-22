namespace LeetCodeEasyTest;

public class UniqueNumberOfOccurrencesTest
{
    [Test]
    public void UniqueNumberOfOccurrences()
    {
        Assert.AreEqual(true, UniqueNumberOfOccurrencesTask.UniqueOccurrences(new int[]{1,2,2,1,1,3}));
        Assert.AreEqual(true, UniqueNumberOfOccurrencesTask.UniqueOccurrences(new int[]{-3,0,1,-3,1,1,1,-3,10,0}));
        Assert.AreEqual(false, UniqueNumberOfOccurrencesTask.UniqueOccurrences(new int[]{1,2}));
    }
}