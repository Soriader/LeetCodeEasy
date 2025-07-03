namespace LeetCodeEasyTest;

public class LongestNiceSubstringTest
{
    [Test]
    public void LongestNiceSubstring()
    {
        Assert.AreEqual("Bb", LongestNiceSubstringTask.LongestNiceSubstring("Bb"));
        Assert.AreEqual("cChH", LongestNiceSubstringTask.LongestNiceSubstring("cChH"));
        Assert.AreEqual("aAa", LongestNiceSubstringTask.LongestNiceSubstring("YazaAay"));
        Assert.AreEqual("", LongestNiceSubstringTask.LongestNiceSubstring("c"));
    }
}