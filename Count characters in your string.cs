//The main idea is to count all the occurring characters in a string. 
//If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
//What if the string is empty ? Then the result should be empty object literal, {}.

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        string tmp = new String(str.Distinct().ToArray());
        for (int i = 0; i < tmp.Length; i++)
        {
            int freq = str.Count(f => (f == tmp[i]));
            dictionary.Add(tmp[i], freq);
        }

        return dictionary;
    }
}