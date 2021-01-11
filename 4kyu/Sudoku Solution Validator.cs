/*
Sudoku Solution Validator
Write a function validSolution/ValidateSolution/valid_solution() 
that accepts a 2D array representing a Sudoku board, and returns true if it is a valid solution, 
or false otherwise. The cells of the sudoku board may also contain 0's, which will represent empty cells. 
Boards containing one or more zeroes are considered to be invalid solutions.

The board is always 9 cells by 9 cells, and every cell only contains integers from 0 to 9.
*/



using System;
public class Sudoku
{
    public static bool ValidateSolution(int[][] board)
    {
        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
                if (board[i][j] > 9 || board[i][j] < 1) return false;

        for (int i = 0; i < 9; i++)
        {
            if (!Check("row", i, 0, 0, board) || !Check("col", i, 0, 0, board)) return false;
            if (i % 3 == 0)
                for (int j = 0; j < 9; j += 3)
                    if (!Check("square", 0, i, j, board)) return false;
        }
        return true;
    }

    static bool Check(string what, int index, int startingX, int startingY, int[][] board)
    {
        bool[] occurenceOfNumber = new bool[9];
        for (int i = 0; i < 9; i++)
            occurenceOfNumber[i] = false;

        if (what == "row")
            for (int i = 0; i < 9; i++)
                occurenceOfNumber[board[i][index] - 1] = true;
        else if (what == "col")
            for (int i = 0; i < 9; i++)
                occurenceOfNumber[board[i][index] - 1] = true;
        else if (what == "square")
            for (int i = startingX; i < startingX + 3; i++)
                for (int j = startingY; j < startingY + 3; j++)
                    occurenceOfNumber[board[i][j] - 1] = true;

        for (int i = 0; i < 9; i++)
            if (occurenceOfNumber[i] == false)
                return false;
        return true;
    }
}