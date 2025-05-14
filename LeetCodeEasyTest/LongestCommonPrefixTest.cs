namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class LongestCommonPrefixTest
{
    [Test]
    public void LongestCommonPrefix()
    {
        Assert.AreEqual("fl", LongestCommonPrefixTask.LongestCommonPrefix(new string[]{"flower","flow","flight"}));
        Assert.AreEqual("", LongestCommonPrefixTask.LongestCommonPrefix(new string[]{"dog","racecar","car"}));
        Assert.AreEqual("a", LongestCommonPrefixTask.LongestCommonPrefix(new string[]{"bagdat","lara","car"}));
        Assert.AreEqual("a", LongestCommonPrefixTask.LongestCommonPrefix(new string[]{"ab", "a"}));
        
    }
}