namespace LeetCodeEasyTest;

public class NumberOfUnequalTripletsInArrayTest
{
    [Test]
    public void NumberOfUnequalTripletsInArray()
    {
        Assert.AreEqual(3, NumberOfUnequalTripletsInArrayTask.UnequalTriplets(new[] { 4,4,2,4,3 }));
        Assert.AreEqual(0, NumberOfUnequalTripletsInArrayTask.UnequalTriplets(new[] { 1,1,1,1,1 }));
    }
    
}