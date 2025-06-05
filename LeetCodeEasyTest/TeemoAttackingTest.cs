namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class TeemoAttackingTest
{
    [Test]
    public void TeemoAttacking()
    {
        Assert.AreEqual(3, TeemoAttackingTask.FindPoisonedDuration(new int[]{1,2}, 2));
        Assert.AreEqual(4, TeemoAttackingTask.FindPoisonedDuration(new int[]{1,4}, 2));
        Assert.AreEqual(9, TeemoAttackingTask.FindPoisonedDuration(new int[]{1,2,3,4,5}, 5));
    }
}