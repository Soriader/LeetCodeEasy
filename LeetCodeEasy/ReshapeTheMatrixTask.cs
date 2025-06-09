namespace LeetCodeEasy;

public class ReshapeTheMatrixTask
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int m = mat.Length;
        int n = mat[0].Length;
    
        if (m * n != r * c) 
        {
            return mat;
        }
    
        int[][] result = new int[r][];
        
        for (int i = 0; i < r; i++) 
        {
            result[i] = new int[c];
        }

        int row = 0; 
        int col = 0;
        
        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                result[row][col] = mat[i][j];
                col++;
                
                if (col == c) 
                {
                    col = 0;
                    row++;
                }
            }
        }
    
        return result;
    }
}
//https://leetcode.com/problems/reshape-the-matrix/description/