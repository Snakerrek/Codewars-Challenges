/*  
Digital root is the recursive sum of all the digits in a number.
Given n, take the sum of the digits of n. If that value has more than one digit,
continue reducing in this way until a single-digit number is produced. 
The input will be a non-negative integer.
*/
using System;
using System.Collections.Generic;
public class Number
{
    public int DigitalRoot(long n)
    {
        long sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        if (sum < 10) return (int)sum;
        else return DigitalRoot(sum);
    }

}