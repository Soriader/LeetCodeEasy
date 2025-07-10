namespace LeetCodeEasyTest;

public class NumberOfDifferentIntegersInAStringTest
{
    [Test]
    public void NumberOfDifferentIntegersInAString()
    {
        
        Assert.AreEqual(3, NumberOfDifferentIntegersInAStringTask.NumDifferentIntegers("a123bc34d8ef34"));
        Assert.AreEqual(2, NumberOfDifferentIntegersInAStringTask.NumDifferentIntegers("leet1234code234"));
        Assert.AreEqual(1, NumberOfDifferentIntegersInAStringTask.NumDifferentIntegers("a1b01c001"));
        
    }
}