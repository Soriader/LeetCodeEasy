namespace LeetCodeEasyTest;

public class KidsWithTheGreatestNumberOfCandiesTest
{
    [Test]
    public void KidsWithTheGreatestNumberOfCandies()
    {
        Assert.AreEqual(new List<bool>(){true,true,true,false,true}, KidsWithTheGreatestNumberOfCandiesTask.KidsWithCandies(new int[]{2,3,5,1,3}, 3));
        Assert.AreEqual(new List<bool>(){true,false,true}, KidsWithTheGreatestNumberOfCandiesTask.KidsWithCandies(new int[]{12, 1, 12}, 10));
    }
}