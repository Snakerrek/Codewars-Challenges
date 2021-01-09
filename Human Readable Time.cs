/*
 Write a function, which takes a non-negative integer (seconds) 
as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)
*/

using System;
public static class TimeFormat
{
    public static string GetReadableTime(int s)
    {
        string result = "";
        int[] time = new int[3] { s / 3600, (s % 3600) / 60, ((s % 3600) % 60) };
        for (int i = 0; i < 3; i++)
        {
            if (i > 0) result += ":";
            if (time[i] < 10) result += "0";

            result += time[i].ToString();
        }
        return result;
    }
}