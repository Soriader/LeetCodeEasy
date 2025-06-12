namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class BaseballGameTest
{
    [Test]
    public void BaseballGame()
    {
        Assert.AreEqual(30,BaseballGameTask.CalPoints(new string[]{"5","2","C","D","+"}));
        Assert.AreEqual(27,BaseballGameTask.CalPoints(new string[]{"5","-2","4","C","D","9","+","+"}));
    }
}