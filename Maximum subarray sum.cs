/*
 The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:

maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
-- should be 6: [4, -1, 2, 1]

Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. 
If the list is made up of only negative numbers, return 0 instead.
Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
*/

public static class Kata
{
    public static int MaxSequence(int[] arr)
    {
        if (arr.Length == 0) return 0; // empty array case

        int tmp = 0, best_sum = arr[0];
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] < 0) tmp++;

        if (tmp == arr.Length) return 0; // all negative numbers case

        for (int i = 1; i <= arr.Length; i++)
            for (int j = 0; j < arr.Length; j++)
                if (Sum(arr, j, i - j) > best_sum) best_sum = Sum(arr, j, i - j);
        return best_sum;
    }

    public static int Sum(int[] arr, int startingPos, int howManyNumbers)
    {
        int sum = 0;
        for (int i = startingPos; i < startingPos + howManyNumbers; i++)
            sum += arr[i];
        return sum;
    }
}