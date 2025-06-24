namespace LeetCodeEasyTest;

public class FindAllKDistantIndicesInAnArrayTest
{
    [Test]
    public void FindAllKDistantIndicesInAnArray()
    {
        Assert.AreEqual(new[]{1,2,3,4,5,6}, FindAllKDistantIndicesInAnArrayTask.FindKDistantIndices(new[] { 3,4,9,1,3,9,5 }, 9, 1));
    }
}