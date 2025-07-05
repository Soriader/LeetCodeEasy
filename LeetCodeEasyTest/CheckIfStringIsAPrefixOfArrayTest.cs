namespace LeetCodeEasyTest;

public class CheckIfStringIsAPrefixOfArrayTest
{
    [Test]
    public void SecondLargestDigitInAString()
    {
        Assert.AreEqual(true, CheckIfStringIsAPrefixOfArrayTask.IsPrefixString("iloveleetcode", new string[]{"i","love","leetcode","apples"}));
        Assert.AreEqual(false, CheckIfStringIsAPrefixOfArrayTask.IsPrefixString("iloveleetcode", new string[]{"apples","i","love","leetcode"}));
    }
}