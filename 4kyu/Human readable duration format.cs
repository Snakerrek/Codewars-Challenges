/*
Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.

It is much easier to understand with an example:

formatDuration(62)    // returns "1 minute and 2 seconds"
formatDuration(3662)  // returns "1 hour, 1 minute and 2 seconds"
For the purpose of this Kata, a year is 365 days and a day is 24 hours.

Note that spaces are important.
*/


using System;
using System.Collections.Generic;
public class HumanTimeFormat
{
    public static string formatDuration(int s)
    {
        if (s == 0) return "now";
        int[] time = new int[5];

        time[0] = s / (365 * 24 * 60 * 60);
        s -= time[0] * (365 * 24 * 60 * 60);
        time[1] = s / (24 * 60 * 60);
        s -= time[1] * (24 * 60 * 60);
        time[2] = s / (60 * 60);
        s -= time[2] * (60 * 60);
        time[3] = s / 60;
        s -= time[3] * 60;
        time[4] = s;

        return CombineString(time);
    }

    static string CombineString(int[] time)
    {
        string result = "";
        List<string> segment = new List<string>();

        if (time[0] > 0) { segment.Add((time[0] > 1) ? (time[0] + " years") : (time[0] + " year")); }
        if (time[1] > 0) { segment.Add((time[1] > 1) ? (time[1] + " days") : (time[1] + " day")); }
        if (time[2] > 0) { segment.Add((time[2] > 1) ? (time[2] + " hours") : (time[2] + " hour")); }
        if (time[3] > 0) { segment.Add((time[3] > 1) ? (time[3] + " minutes") : (time[3] + " minute")); }
        if (time[4] > 0) { segment.Add((time[4] > 1) ? (time[4] + " seconds") : (time[4] + " second")); }

        for (int i = 0; i < segment.Count; i++)
        {
            if (i > 0)
            {
                if (i == segment.Count - 1)
                    result += " and ";
                else
                    result += ", ";
            }
            result += segment[i];
        }
        return result;
    }
}