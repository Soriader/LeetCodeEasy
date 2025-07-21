namespace LeetCodeEasyTest;

public class FindSubarraysWithEqualSumTest
{
    [Test]
    public void FindSubarraysWithEqualSum()
    {
        Assert.AreEqual(false, FindSubarraysWithEqualSumTask.FindSubarrays(new int[] { 1, 3, 5, 7 }));
        Assert.AreEqual(true, FindSubarraysWithEqualSumTask.FindSubarrays(new int[] { 4,2,4 }));
    }
}