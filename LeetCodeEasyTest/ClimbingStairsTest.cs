namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class ClimbingStairsTest
{
    [Test]
    public void ClimbingStairs()
    {
        Assert.AreEqual(2, ClimbingStairsTask.ClimbStairs(2));
        Assert.AreEqual(3, ClimbingStairsTask.ClimbStairs(3));
        Assert.AreEqual(1, ClimbingStairsTask.ClimbStairs(1));
        Assert.AreEqual(5, ClimbingStairsTask.ClimbStairs(4));
    }
}