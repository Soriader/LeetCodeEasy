namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class ShortestCompletingWordTest
{
    [Test]
    public void ShortestCompWord()
    {
        Assert.AreEqual("pest", ShortestCompletingWordTask.ShortestCompletingWord("1s3 456",new string[]{"looks","pest","stew","show"}));
    }
}