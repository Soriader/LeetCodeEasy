namespace LeetCodeEasyTest;

public class NumberOfDaysBetweenTwoDatesTest
{
    [Test]
    public void NumberOfDaysBetweenTwoDates()
    {
        Assert.AreEqual(1, NumberOfDaysBetweenTwoDatesTask.DaysBetweenDates("2019-06-29", "2019-06-30"));
        Assert.AreEqual(15, NumberOfDaysBetweenTwoDatesTask.DaysBetweenDates("2020-01-15", "2019-12-31"));
    }
}