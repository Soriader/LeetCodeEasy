namespace LeetCodeEasyTest;

public class DivideAStringIntoGroupsOfSizeKTest
{
    [Test]
    public void DivideAStringIntoGroupsOfSizeK()
    {
        Assert.AreEqual(new string[]{"abc","def","ghi"},DivideAStringIntoGroupsOfSizeKTask.DivideString("abcdefghi", 3, 'x'));
        Assert.AreEqual(new string[]{"abc","def","ghi","jxx"},DivideAStringIntoGroupsOfSizeKTask.DivideString("abcdefghij", 3, 'x'));
    }
}