namespace LeetCodeEasyTest;

public class SumOfAllOddLengthSubarraysTest
{
    [Test]
    public void SumOfAllOddLengthSubarrays()
    {
        Assert.AreEqual(58, SumOfAllOddLengthSubarraysTask.SumOddLengthSubarrays(new int[]{1,4,2,5,3}));
        Assert.AreEqual(3, SumOfAllOddLengthSubarraysTask.SumOddLengthSubarrays(new int[]{1,2}));
        Assert.AreEqual(66, SumOfAllOddLengthSubarraysTask.SumOddLengthSubarrays(new int[]{10,11,12}));
    }
}