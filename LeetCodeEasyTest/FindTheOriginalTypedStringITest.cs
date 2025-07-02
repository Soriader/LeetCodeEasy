namespace LeetCodeEasyTest;

public class FindTheOriginalTypedStringITest
{
    [Test]
    public void FindTheOriginalTypedStringI()
    {
        Assert.AreEqual(5, FindTheOriginalTypedStringITask.PossibleStringCount("abbcccc"));
        Assert.AreEqual(1, FindTheOriginalTypedStringITask.PossibleStringCount("abcd"));
        Assert.AreEqual(4, FindTheOriginalTypedStringITask.PossibleStringCount("aaaa"));
    }
}