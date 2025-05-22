namespace LeetCodeEasy;

public class StudentAttendanceRecordITask
{
    public static bool CheckRecord(string s)
    {
        int isAbsent = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'A')
            {
                isAbsent++;
                if (isAbsent >= 2)
                {
                    return false;
                }
            }

            if (i + 2 < s.Length 
                && s[i] == 'L' 
                && s[i + 1] == 'L' 
                && s[i + 2] == 'L')
            {
                return false;
            }
        }
        
        
        return true;
    }
}
//https://leetcode.com/problems/student-attendance-record-i/description/