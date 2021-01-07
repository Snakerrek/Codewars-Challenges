/*
A natural number is called k-prime if it has exactly k prime factors, 
counted with multiplicity. For example:

k = 2-- > 4, 6, 9, 10, 14, 15, 21, 22, ...
k = 3-- > 8, 12, 18, 20, 27, 28, 30, ...
k = 5-- > 32, 48, 72, 80, 108, 112, ...

A natural number is thus prime if and only if it is 1-prime.
*/
using System;
using System.Collections.Generic;

public class KPrimes
{

    public static long[] CountKprimes(int k, long start, long end)
    {
        List<long> result = new List<long>();

        for (long i = start == 0 ? 2 : start; i <= end; i++)
        {
            int numOfFactors = 0;
            long cur = i;

            for (int j = 2; j <= cur / j; j++)
            {
                while (cur % j == 0)
                {
                    numOfFactors++;
                    cur /= j;
                }
            }

            if (cur > 1) numOfFactors++;
            if (numOfFactors == k) result.Add(i);
        }
        long[] answer = new long[result.Count];
        for (int i = 0; i < answer.Length; i++)
            answer[i] = result[i];

        return answer;
    }

    public static int Puzzle(int s)
    {
        int combinations = 0;

        long[] onePrimes = CountKprimes(1, 2, s);
        long[] threePrimes = CountKprimes(3, 2, s);
        long[] sevenPrimes = CountKprimes(7, 2, s);

        foreach (long i in onePrimes)
        {
            foreach (long j in threePrimes)
            {
                foreach (long k in sevenPrimes)
                {
                    if (i + j + k == s) combinations++;
                }
            }
        }

        return combinations;
    }
}