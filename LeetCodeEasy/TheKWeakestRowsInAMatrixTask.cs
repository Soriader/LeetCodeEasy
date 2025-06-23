namespace LeetCodeEasy;

public class TheKWeakestRowsInAMatrixTask
{
    public static int[] KWeakestRows(int[][] mat, int k)
    {
        var soliderSummary = new Dictionary<int, int>();
        int iterator = 0;

        for (int i = 0; i < mat.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            soliderSummary.Add(iterator, count);
            iterator++;
        }
        
        var result = new List<int>();
        iterator = 0;

        while (iterator != k)
        {
            var weakestRow = soliderSummary.OrderBy(x => x.Value).First();
            result.Add(weakestRow.Key);
    
            soliderSummary.Remove(weakestRow.Key);
            iterator++;
        }
        
        return result.ToArray();
    }
}
//https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/description/