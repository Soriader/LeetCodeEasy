namespace LeetCodeEasyTest;

public class SortThePeopleTest
{
    [Test]
    public void SortThePeople()
    {
        Assert.AreEqual(new string[]{"Mary","Emma","John"}, 
            SortThePeopleTask.SortPeople(new string[]{"Mary","John","Emma"}, new int[]{180,165,170}));
        
        Assert.AreEqual(new string[]{"Bob","Alice","Bob"}, 
            SortThePeopleTask.SortPeople(new string[]{"Alice","Bob","Bob"}, new int[]{155,185,150}));
    }
}