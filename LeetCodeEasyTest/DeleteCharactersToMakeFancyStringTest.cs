namespace LeetCodeEasyTest;

public class DeleteCharactersToMakeFancyStringTest
{
    [Test]
    public void DeleteCharactersToMakeFancyString()
    {
        Assert.AreEqual("leetcode", DeleteCharactersToMakeFancyStringTask.MakeFancyString("leeetcode"));
        Assert.AreEqual("aabaa", DeleteCharactersToMakeFancyStringTask.MakeFancyString("aaabaaaa"));
        Assert.AreEqual("aab", DeleteCharactersToMakeFancyStringTask.MakeFancyString("aab"));
    }
}