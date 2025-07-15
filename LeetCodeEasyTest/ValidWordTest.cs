namespace LeetCodeEasyTest;

public class ValidWordTest
{
    [Test]
    public void ValidWord()
    {
        Assert.IsTrue(ValidWordTask.IsValid("234Adas"));
        Assert.IsTrue(ValidWordTask.IsValid("UuE6"));
        Assert.IsFalse(ValidWordTask.IsValid("b3"));
        Assert.IsFalse(ValidWordTask.IsValid("a3$e"));
    }
}