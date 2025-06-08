namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class FindTheDifferenceTest
{
    [Test]
    public void ShortestCompWord()
    {
        Assert.AreEqual('e', FindTheDifferenceTask.FindTheDifference("abcd", "abcde"));
    }
}