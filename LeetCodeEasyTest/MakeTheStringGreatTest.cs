namespace LeetCodeEasyTest;

public class MakeTheStringGreatTest
{
    [Test]
    public void MakeTheStringGreat()
    {
        Assert.AreEqual("leetcode", MakeTheStringGreatTask.MakeGood("leEeetcode"));
        Assert.AreEqual("", MakeTheStringGreatTask.MakeGood("abBAcC"));
        Assert.AreEqual("s", MakeTheStringGreatTask.MakeGood("s"));
        Assert.AreEqual("mC", MakeTheStringGreatTask.MakeGood("mC"));
    }
}