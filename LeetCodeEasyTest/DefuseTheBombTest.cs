namespace LeetCodeEasyTest;

public class DefuseTheBombTest
{
    [Test]
    public void Test()
    {
        Assert.AreEqual(new int[]{12,10,16,13}, DefuseTheBombTask.Decrypt(new int[]{5,7,1,4}, 3));
        Assert.AreEqual(new int[]{12,5,6,13}, DefuseTheBombTask.Decrypt(new int[]{2,4,9,3}, -2));
        Assert.AreEqual(new int[]{0,0,0,0}, DefuseTheBombTask.Decrypt(new int[]{2,4,9,3}, 0));
    }
}