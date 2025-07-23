namespace LeetCodeEasyTest;

public class CheckArrayFormationThroughConcatenationTest
{
    [Test]
    public void CheckArrayFormationThroughConcatenation()
    {
        Assert.AreEqual(true, CheckArrayFormationThroughConcatenationTask.CanFormArray(new int[]{15,88},new int[][]{[88],[15]}));
        Assert.AreEqual(false, CheckArrayFormationThroughConcatenationTask.CanFormArray(new int[]{49,18,16},new int[][]{[16,18,49]}));
    }
}