/*
Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. 
The function should return true if the string is valid, and false if it's invalid.
*/

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int parentheses = 0;
        foreach (char character in input)
        {
            if (parentheses < 0)
                return false;
            if (character == '(')
                parentheses++;
            else if (character == ')')
                parentheses--;
        }
        return parentheses == 0;
    }
}