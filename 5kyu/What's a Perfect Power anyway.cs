/*
Your task is to check wheter a given integer is a perfect power. 
If it is a perfect power, return a pair m and k with mk = n as a proof. 
Otherwise return Nothing, Nil, null, NULL, None or your language's equivalent.
*/
using System;

public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; Math.Pow(i, 2) < n + 1; i++)
            for (int j = 2; Math.Pow(i, j) < n + 1; j++)
                if (Math.Pow(i, j) == n)
                    return (i, j);
        return null;
    }
}