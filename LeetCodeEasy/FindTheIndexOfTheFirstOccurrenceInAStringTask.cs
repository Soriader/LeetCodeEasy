﻿namespace LeetCodeEasy;

public class FindTheIndexOfTheFirstOccurrenceInAStringTask
{
    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            bool found = true;
            
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                return i;
            }
        }

        return -1;
    }
}
//https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/