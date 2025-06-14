namespace LeetCodeEasyTest;

public class GoatLatinTest
{
    [Test]
    public void GoatLatin()
    {
        Assert.AreEqual("Imaa peaksmaaa oatGmaaaa atinLmaaaaa", GoatLatinTask.ToGoatLatin("I speak Goat Latin"));
    }
}