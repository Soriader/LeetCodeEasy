namespace LeetCodeEasyTest;

public class TheKWeakestRowsInAMatrixTest
{
    [Test]
    public void TheKWeakestRowsInAMatrix()
    {
        var mat = new int[][]
        {
            new int[] { 1,1,0,0,0}, 
            new int[] { 1,1,1,1,0 },
            new int[] { 1,0,0,0,0 },
            new int[] { 1,1,0,0,0 },
            new int[] { 1,1,1,1,1 }
        };
        
        Assert.AreEqual(new int[]{2,0,3}, TheKWeakestRowsInAMatrixTask.KWeakestRows(mat, 3));
    }
}