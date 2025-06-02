namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class AddDigitsTest
{
    [Test]
    public void AddDigits()
    {
        Assert.AreEqual(2, AddDigitsTask.AddDigits(38));
        Assert.AreEqual(0, AddDigitsTask.AddDigits(0));
        Assert.AreEqual(6, AddDigitsTask.AddDigits(15));
    }
}