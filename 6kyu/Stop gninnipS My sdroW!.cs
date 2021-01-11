/*
Write a function that takes in a string of one or more words, 
and returns the same string, but with all five or more letter words 
reversed (Just like the name of this Kata). 
Strings passed in will consist of only letters and spaces. 
Spaces will be included only when more than one word is present.

Examples: 
spinWords("Hey fellow warriors") => returns "Hey wollef sroirraw" 
spinWords("This is a test") => returns "This is a test" 
spinWords("This is another test")=> returns "This is rehtona test"
*/
using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        string result = "";
        string[] words = sentence.Split(" ");

        if (words.Length == 0) return (sentence.Length < 5) ? sentence : ReverseString(sentence);
        else
        {
            for (int i = 0; i < words.Length; i++)
            {
                result += (words[i].Length < 5) ? words[i] : ReverseString(words[i]);
                result += (i != words.Length - 1) ? " " : "";
            }
        }
        return result;
    }

    public static string ReverseString(string source)
    {
        string result = "";
        for (int i = source.Length - 1; i >= 0; i--)
            result += source[i];

        return result;
    }
}