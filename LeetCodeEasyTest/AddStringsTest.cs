namespace LeetCodeEasyTest;

public class AddStringsTest
{
    [Test]
    public void AddStrings()
    {
        Assert.AreEqual("134", AddStringsTask.AddStrings("11", "123"));
        Assert.AreEqual("533", AddStringsTask.AddStrings("456", "77"));
    }
}