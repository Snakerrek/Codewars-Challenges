/*
Create a function taking a positive integer as its parameter and returning 
a string containing the Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately 
starting with the left most digit and skipping any digit with a value of zero.
In Roman numerals 1990 is rendered: 1000 = M, 900 = CM, 90 = XC; 
resulting in MCMXC. 2008 is written as 2000 = MM, 8 = VIII; or MMVIII. 
1666 uses each Roman symbol in descending order: MDCLXVI.
*/
using System;

public class RomanConvert
{
    public static string Solution(int n)
    {
        if (n >= 1000) return "M" + Solution(n - 1000);
        if (n >= 900) return "CM" + Solution(n - 900);
        if (n >= 500) return "D" + Solution(n - 500);
        if (n >= 400) return "CD" + Solution(n - 400);
        if (n >= 100) return "C" + Solution(n - 100);
        if (n >= 90) return "XC" + Solution(n - 90);
        if (n >= 50) return "L" + Solution(n - 50);
        if (n >= 40) return "XL" + Solution(n - 40);
        if (n >= 10) return "X" + Solution(n - 10);
        if (n >= 9) return "IX" + Solution(n - 9);
        if (n >= 5) return "V" + Solution(n - 5);
        if (n >= 4) return "IV" + Solution(n - 4);
        if (n >= 1) return "I" + Solution(n - 1);
        return string.Empty;
    }
}