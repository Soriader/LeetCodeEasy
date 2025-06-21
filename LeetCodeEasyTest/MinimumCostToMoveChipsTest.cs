namespace LeetCodeEasyTest;

public class MinimumCostToMoveChipsTest
{
    [Test]
    public void MinCostToMoveChips()
    {
        Assert.AreEqual(1, MinimumCostToMoveChipsTask.MinCostToMoveChips(new int[] { 1, 2, 3 }));
        Assert.AreEqual(1, MinimumCostToMoveChipsTask.MinCostToMoveChips(new int[] { 1,1000000000 }));
        Assert.AreEqual(2, MinimumCostToMoveChipsTask.MinCostToMoveChips(new int[] { 2,2,2,3,3 }));
    }
}