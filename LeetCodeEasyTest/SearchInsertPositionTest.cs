namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class SearchInsertPositionTest
{
    [Test]
    public void SearchInsertPosition()
    {
        Assert.AreEqual(2, SearchInsertPositionTask.SearchInsert(new int[]{1,3,5,6}, 5));
        Assert.AreEqual(4, SearchInsertPositionTask.SearchInsert(new int[]{1,3,5,6}, 7));
        Assert.AreEqual(1, SearchInsertPositionTask.SearchInsert(new int[]{1,3,5,6}, 2));
        Assert.AreEqual(0, SearchInsertPositionTask.SearchInsert(new int[]{1,3,5,6}, 0));

    }
}