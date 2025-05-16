namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class FindTheIndexOfTheFirstOccurrenceInAStringTest
{
    [Test]
    public void FindTheIndexOfTheFirstOccurrenceInAString()
    {
        Assert.AreEqual(0, FindTheIndexOfTheFirstOccurrenceInAStringTask.StrStr(("sadbutsad"), "sad"));
        Assert.AreEqual(2, FindTheIndexOfTheFirstOccurrenceInAStringTask.StrStr(("hello"), "ll"));
        Assert.AreEqual(-1, FindTheIndexOfTheFirstOccurrenceInAStringTask.StrStr(("leetcode"), "leeto"));
    }
}