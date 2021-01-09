/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int[] result = new int[arr.Length];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                result[index] = arr[i];
                index++;
            }
        }
        for (int i = index; i < result.Length; i++)
        {
            result[i] = 0;
        }
        return result;
    }
}