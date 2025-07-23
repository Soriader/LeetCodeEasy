namespace LeetCodeEasyTest;

public class DetermineColorOfAChessboardSquareTest
{
    [Test]
    public void DetermineColorOfAChessboardSquare()
    {
        Assert.AreEqual(false, DetermineColorOfAChessboardSquareTask.SquareIsWhite("a1"));
        Assert.AreEqual(true, DetermineColorOfAChessboardSquareTask.SquareIsWhite("a2"));
        Assert.AreEqual(true, DetermineColorOfAChessboardSquareTask.SquareIsWhite("h3"));
    }
}