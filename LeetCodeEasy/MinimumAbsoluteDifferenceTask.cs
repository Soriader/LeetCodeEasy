namespace LeetCodeEasy;

public class MinimumAbsoluteDifferenceTask
{
    public static IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);
        
        int minDiff = int.MaxValue;
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int currentDiff = arr[i + 1] - arr[i];
            if (currentDiff < minDiff)
            {
                minDiff = currentDiff;
            }
        }
        

        var result = new List<IList<int>>();
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] == minDiff)
            {
                result.Add(new List<int> { arr[i], arr[i + 1] });
            }
        }
        
        return result;
    }
}
//https://leetcode.com/problems/minimum-absolute-difference/description/