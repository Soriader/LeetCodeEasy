namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class MinimumTimeToTypeWordByTypewriterTest
{
    [Test]
    public void MinimumTimeToTypeWordByTypewriter()
    {
        Assert.AreEqual(5, MinimumTimeToTypeWordByTypewriterTask.MinTimeToType("abc"));
        Assert.AreEqual(7, MinimumTimeToTypeWordByTypewriterTask.MinTimeToType("bza"));
    }
}