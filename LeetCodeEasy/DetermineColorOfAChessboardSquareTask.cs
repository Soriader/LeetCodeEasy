namespace LeetCodeEasy;

public class DetermineColorOfAChessboardSquareTask
{
    public static bool SquareIsWhite(string coordinates)
    {
        var firstIsBlack = "aceg";
        var firstIsWhite = "bdfh";

        if ((coordinates[1] - '0') % 2 == 0 && firstIsBlack.Contains(coordinates[0]) 
            ||(coordinates[1] - '0') % 2 != 0 && firstIsWhite.Contains(coordinates[0]))
        {
            return true;
        }
        
        return false;
    }
}
//https://leetcode.com/problems/determine-color-of-a-chessboard-square/