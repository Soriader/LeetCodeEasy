namespace LeetCodeEasy;

public class KthMissingPositiveNumberTask
{
    public static int FindKthPositive(int[] arr, int k) 
    {
        var missingNumbers = new List<int>();
        int currentNumber = 1;
        int index = 0;

        while (missingNumbers.Count < k)
        {
            if (index < arr.Length && arr[index] == currentNumber)
            {
                index++;
            }
            else
            {
                missingNumbers.Add(currentNumber);
            }
            currentNumber++;
        }

        return missingNumbers[k - 1];
    }
}
//https://leetcode.com/problems/kth-missing-positive-number/description/