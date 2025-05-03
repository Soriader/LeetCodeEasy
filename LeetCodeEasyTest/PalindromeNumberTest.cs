namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class PalindromeNumberTest
{
    [Test]
    public void IsPalindromeNumber()
    {
        Assert.AreEqual(true, PalindromeNumberTask.IsPalindrome(121));
        Assert.AreEqual(true, PalindromeNumberTask.IsPalindrome(1223221));
        Assert.AreEqual(false, PalindromeNumberTask.IsPalindrome(-121));
        Assert.AreEqual(false, PalindromeNumberTask.IsPalindrome(18642));
        
    }
}