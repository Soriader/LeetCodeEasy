namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class ValidParentheseTest
{
    [Test]
    public void ValidParenthese()
    {
        Assert.AreEqual(true, ValidParentheseTask.IsValid("()"));
        Assert.AreEqual(true, ValidParentheseTask.IsValid("(())"));
        Assert.AreEqual(true, ValidParentheseTask.IsValid("()[]{}"));
        Assert.AreEqual(true, ValidParentheseTask.IsValid("([])"));
        Assert.AreEqual(false, ValidParentheseTask.IsValid("(]"));
    }
}