namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class AddBinaryTest
{
    [Test]
    public void AddBinary()
    {
        Assert.AreEqual("10101", AddBinaryTask.AddBinary("1010","1011"));
    }
}