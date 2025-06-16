namespace LeetCodeEasyTest;

public class JewelsAndStonesTest
{
    [Test]
    public void JewelsAndStones()
    {
        Assert.AreEqual(3, JewelsAndStonesTask.NumJewelsInStones("aA", "aAAbbbb"));
        Assert.AreEqual(0, JewelsAndStonesTask.NumJewelsInStones("z", "ZZ"));
    }
}
