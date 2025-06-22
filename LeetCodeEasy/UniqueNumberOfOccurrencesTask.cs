namespace LeetCodeEasy;

public class UniqueNumberOfOccurrencesTask
{
    public static bool UniqueOccurrences(int[] arr) 
    {
        var countTheNumbers = new Dictionary<int, int>();

        foreach (var number in arr)
        {
            if (countTheNumbers.ContainsKey(number))
            {
                countTheNumbers[number]++;
            }
            else
            {
                countTheNumbers.Add(number, 1);
            }
        }

        var occurrences = countTheNumbers.Values;
        return occurrences.Distinct().Count() == occurrences.Count();
    }
}
//https://leetcode.com/problems/unique-number-of-occurrences/