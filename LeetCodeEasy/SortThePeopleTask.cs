namespace LeetCodeEasy;

public class SortThePeopleTask
{
    public static string[] SortPeople(string[] names, int[] heights) 
    {
        var people = names.Zip(heights, (name, height) => new { name, height });
        
        return people.OrderByDescending(p => p.height)
            .Select(p => p.name)
            .ToArray();
    }
}
//https://leetcode.com/problems/sort-the-people/