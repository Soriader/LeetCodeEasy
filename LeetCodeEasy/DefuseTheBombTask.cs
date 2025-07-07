namespace LeetCodeEasy;

public class DefuseTheBombTask
{
    public static int[] Decrypt(int[] code, int k) 
    {
        int n = code.Length;
        var result = new int[n];
        int step = k > 0 ? 1 : -1;
        int absK = Math.Abs(k);

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            
            for (int j = 1; j <= absK; j++)
            {
                int pos = (i + j * step + n) % n;
                sum += code[pos];
            }
            
            result[i] = sum;
        }

        return result;
    }
}
//https://leetcode.com/problems/defuse-the-bomb/description/