namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class TwoSumTest
{
    [Test]
    public void TwoSums()
    {
        Assert.AreEqual(new int[]{0,1}, TwoSumTask.TwoSum(new int[]{2,7,11,15}, 9));
        Assert.AreEqual(new int[]{1,2}, TwoSumTask.TwoSum(new int[]{3,2,4}, 6));
        Assert.AreEqual(new int[]{0,1}, TwoSumTask.TwoSum(new int[]{3,3}, 6));
    }
}