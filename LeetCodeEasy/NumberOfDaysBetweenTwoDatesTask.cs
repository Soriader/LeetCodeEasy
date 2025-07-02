namespace LeetCodeEasy;

public class NumberOfDaysBetweenTwoDatesTask
{
    public static int DaysBetweenDates(string date1, string date2)
    {
        var firstDate = DateTime.Parse(date1);
        var secondDate = DateTime.Parse(date2);
        
        var difference = secondDate - firstDate;
        
        return Math.Abs(difference.Days);
    }
}
//https://leetcode.com/problems/number-of-days-between-two-dates/