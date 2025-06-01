namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class ReverseStringTest
{
    [Test]
    public void ReverseStringTestOne()
    {
        char[] input = { 'h', 'e', 'l', 'l', 'o' };
        char[] expected = { 'o', 'l', 'l', 'e', 'h' };

        ReverseStringTask.ReverseString(input);

        Assert.That(input, Is.EqualTo(expected));
    }
    
    [Test]
    public void ReverseStringTestTwo()
    {
        char[] input = { 'h', 'a', 'n', 'n', 'o', 'h' };
        char[] expected = { 'h', 'o', 'n', 'n', 'a', 'h' };

        ReverseStringTask.ReverseString(input);

        Assert.That(input, Is.EqualTo(expected));
    }
    
    [Test]
    public void ReverseStringTestThree()
    {
        // Arrange
        char[] input = { 'a' };
        char[] expected = { 'a' };

        // Act
        ReverseStringTask.ReverseString(input);

        // Assert
        Assert.That(input, Is.EqualTo(expected));
    }
}