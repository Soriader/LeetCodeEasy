namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class RemoveElementTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(5, RemoveElementTask.RemoveElement(new int[] { 0,1,2,2,3,0,4,2 }, 2));
    }
}