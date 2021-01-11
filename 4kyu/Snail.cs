/*
    Snail Sort
    Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

    array = [[1,2,3],
             [4,5,6],
             [7,8,9]]
    snail(array) #=> [1,2,3,6,9,8,7,4,5]
    For better understanding, please follow the numbers of the next array consecutively:

    array = [[1,2,3],
             [8,9,4],
             [7,6,5]]
    snail(array) #=> [1,2,3,4,5,6,7,8,9]
*/

using System;
using System.Collections.Generic;
public class SnailSolution
{
    struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public static int[] Snail(int[][] array)
    {
        if (array[0].Length < 1)
            return new int[] { };
        else
        {
            Coordinate pos = new Coordinate(0, 0);
            int[] moves = GenerateMoves(array.Length);
            List<int> answer = new List<int>();
            answer.Add(array[0][0]);
            Move(0, moves[0], array, ref answer, ref pos); // first move (try to get rid of it and put into for loop)
            for (int i = 1; i < moves.Length; i++)
            {
                Move(i, moves[i], array, ref answer, ref pos);
            }

            return answer.ToArray();
        }
    }

    static void Move(int moveIndex, int times, int[][] givenArray, ref List<int> answerList, ref Coordinate pos)
    {
        int x = 0, y = 0; // move factors

        if (moveIndex % 4 == 0) { x = 0; y = 1; }        // Move right
        else if (moveIndex % 4 == 1) { x = 1; y = 0; }   // Move down
        else if (moveIndex % 4 == 2) { x = 0; y = -1; }  // Move left
        else if (moveIndex % 4 == 3) { x = -1; y = 0; }  // Move up

        for (int i = 0; i < times; i++)
        {
            pos.x = pos.x + x;
            pos.y = pos.y + y;
            answerList.Add(givenArray[pos.x][pos.y]);
        }
    }


    static int[] GenerateMoves(int arrayLength)
    {
        int[] result = new int[2 * arrayLength - 1];
        int number = arrayLength - 1;
        result[0] = number;
        for (int i = 1; i < result.Length; i++)
        {
            if (i % 2 != 0)
                result[i] = number;
            else
            {
                result[i] = number;
                number--;
            }
        }
        return result;
    }
}