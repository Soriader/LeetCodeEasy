namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class RomanToIntegerTest
{
    [Test]
    public void RomanToInteger()
    {
        Assert.AreEqual(3, RomanToIntegerTask.RomanToInt("III"));
        Assert.AreEqual(58, RomanToIntegerTask.RomanToInt("LVIII"));
        Assert.AreEqual(1994, RomanToIntegerTask.RomanToInt("MCMXCIV"));
    }
}