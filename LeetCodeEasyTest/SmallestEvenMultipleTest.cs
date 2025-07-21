namespace LeetCodeEasyTest;

public class SmallestEvenMultipleTest
{
    [Test]
    public void SmallestEvenMultiple()
    {
        Assert.AreEqual(6, SmallestEvenMultipleTask.SmallestEvenMultiple(6));
        Assert.AreEqual(10, SmallestEvenMultipleTask.SmallestEvenMultiple(5));
    }
}