namespace LeetCodeEasy;

public class CheckArrayFormationThroughConcatenationTask
{
    public static bool CanFormArray(int[] arr, int[][] pieces) 
    {
        Dictionary<int, int[]> map = new Dictionary<int, int[]>();
        
        foreach (var piece in pieces) 
        {
            map[piece[0]] = piece;
        }

        int i = 0;
        while (i < arr.Length) 
        {
            if (!map.ContainsKey(arr[i])) 
            {
                return false;
            }

            int[] piece = map[arr[i]];
            
            for (int j = 0; j < piece.Length; j++) 
            {
                if (i >= arr.Length || arr[i] != piece[j]) 
                {
                    return false;
                }
                
                i++;
            }
        }

        return true;
    }
}
//https://leetcode.com/problems/check-array-formation-through-concatenation/