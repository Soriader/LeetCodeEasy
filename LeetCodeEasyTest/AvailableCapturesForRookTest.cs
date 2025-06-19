namespace LeetCodeEasyTest;

public class AvailableCapturesForRookTest
{
    [Test]
    public void AvailableCapturesForRookTestOne()
    {
        char[][] board = new char[][]
        {
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
        };
        
        Assert.AreEqual(3, AvailableCapturesForRookTask.NumRookCaptures(board));
    }
    
    [Test]
    public void AvailableCapturesForRookTestTwo()
    {
        char[][] board = new char[][]
        {
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
            new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
            new char[] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' },
            new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
            new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
        };
        
        Assert.AreEqual(0, AvailableCapturesForRookTask.NumRookCaptures(board));
    }
}