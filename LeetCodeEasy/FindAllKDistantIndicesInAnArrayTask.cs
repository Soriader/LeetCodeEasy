namespace LeetCodeEasy;

public class FindAllKDistantIndicesInAnArrayTask
{
    public static IList<int> FindKDistantIndices(int[] nums, int key, int k) 
    {
        var result = new List<int>();
        var keyBox = new List<int>();

        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] == key)
            {
                keyBox.Add(j);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            foreach (int j in keyBox)
            {
                if (Math.Abs(i - j) <= k)
                {
                    result.Add(i);
                    break;
                }
            }
        }

        return result;
    }
}
//https://leetcode.com/problems/find-all-k-distant-indices-in-an-array/description/?envType=daily-question&envId=2025-06-24