namespace LeetCodeEasyTest;

public class FindTheKCharacterInGameITest
{
    [Test]
    public void FindTheKCharacterInGameI()
    {
        Assert.AreEqual('b',FindTheKCharacterInGameITask.KthCharacter(5));
        Assert.AreEqual('c',FindTheKCharacterInGameITask.KthCharacter(10));
    }
}