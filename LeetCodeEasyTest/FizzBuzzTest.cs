namespace LeetCodeEasyTest;

public class FizzBuzzTest
{
    [Test]
    public void FizzBuzz()
    {
        Assert.AreEqual(new List<string>(){"1","2","Fizz"}, FizzBuzzTask.FizzBuzz(3));
        Assert.AreEqual(new List<string>(){"1","2","Fizz","4","Buzz"}, FizzBuzzTask.FizzBuzz(5));
        Assert.AreEqual(new List<string>(){"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"},
            FizzBuzzTask.FizzBuzz(15));
    }
}