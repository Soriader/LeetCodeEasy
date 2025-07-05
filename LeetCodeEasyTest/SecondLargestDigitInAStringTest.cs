namespace LeetCodeEasyTest;

public class SecondLargestDigitInAStringTest
{
    [Test]
    public void SecondLargestDigitInAString()
    {
        Assert.AreEqual(2, SecondLargestDigitInAStringTask.SecondHighest("dfa12321afd"));
        Assert.AreEqual(-1, SecondLargestDigitInAStringTask.SecondHighest("abc1111"));
    }
}