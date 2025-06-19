namespace LeetCodeEasy;

public class AvailableCapturesForRookTask
{
    public static int NumRookCaptures(char[][] board)
    {
        int rookRow = -1;
        int rookCol = -1;
        
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (board[i][j] == 'R')
                {
                    rookRow = i;
                    rookCol = j;
                    break;
                }
            }
            if (rookRow != -1) break;
        }

        int attackedPawn = 0;

        int[] directions = { -1, 1 }; 

        foreach (int dir in directions)
        {
            for (int col = rookCol + dir; col >= 0 && col < 8; col += dir)
            {
                if (board[rookRow][col] == 'p')
                {
                    attackedPawn++;
                    break;
                }
                if (board[rookRow][col] != '.')
                {
                    break;
                }
            }
        }

        foreach (int dir in directions)
        {
            for (int row = rookRow + dir; row >= 0 && row < 8; row += dir)
            {
                if (board[row][rookCol] == 'p')
                {
                    attackedPawn++;
                    break;
                }
                if (board[row][rookCol] != '.')
                {
                    break;
                }
            }
        }

        return attackedPawn;
    }
}
//https://leetcode.com/problems/available-captures-for-rook/description/