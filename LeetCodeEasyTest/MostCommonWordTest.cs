namespace LeetCodeEasyTest;

public class MostCommonWordTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual("ball", MostCommonWordTask.MostCommonWord( "Bob hit a ball, the hit BALL flew far after it was hit.", new string[]{"hit"}));
        Assert.AreEqual("a", MostCommonWordTask.MostCommonWord( "a.", new string[]{}));
    }
}