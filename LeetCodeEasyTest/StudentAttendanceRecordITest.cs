namespace LeetCodeEasyTest;

using LeetCodeEasy;

public class StudentAttendanceRecordITest
{
    [Test]
    public void StudentAttendanceRecordI()
    {
        Assert.AreEqual(true, StudentAttendanceRecordITask.CheckRecord("PPALLP"));
        Assert.AreEqual(false, StudentAttendanceRecordITask.CheckRecord("PPALLL"));
        Assert.AreEqual(true, StudentAttendanceRecordITask.CheckRecord("ALL"));
    }
}