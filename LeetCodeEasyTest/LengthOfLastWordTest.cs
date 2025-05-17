namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class LengthOfLastWordTest
{
    [Test]
    public void LengthOfLastWord()
    {
        Assert.AreEqual(5, LengthOfLastWordTask.LengthOfLastWord("Hello World"));
        Assert.AreEqual(4, LengthOfLastWordTask.LengthOfLastWord("   fly me   to   the moon  "));
        Assert.AreEqual(6, LengthOfLastWordTask.LengthOfLastWord("luffy is still joyboy"));
    }
}