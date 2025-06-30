namespace LeetCodeEasyTest;

public class LongestHarmoniousSubsequenceTest
{
    [Test]
    public void LongestHarmoniousSubsequence()
    {
        Assert.AreEqual(5, LongestHarmoniousSubsequenceTask.FindLHS(new int[]{1,3,2,2,5,2,3,7}));
        Assert.AreEqual(2, LongestHarmoniousSubsequenceTask.FindLHS(new int[]{1,2,3,4}));
        Assert.AreEqual(0, LongestHarmoniousSubsequenceTask.FindLHS(new int[]{1,1,1,1}));
    }
}