// Product of Array Except Self
// ============================
//
// You're given an integer array, `arr`. Return a resultant array so that `res[i]` is equal to the product of all the
// elements of `arr` except `arr[i]`.
//
// Write an algorithm that runs in O(n) time without using the division operation.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^5
// - -30 ≤ `arr[i]` ≤ 30
// - The product of any prefix or suffix of `arr` is guaranteed to fit in a 32-bit integer.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P19_ProductOfArrayExceptSelf;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int[] ProductExceptSelf(int[] arr)
    {
        var products = new int[arr.Length];
        products[0] = 1;

        int product = 1;
        for (int i = 1; i != arr.Length; i++)
        {
            product *= arr[i - 1];
            products[i] = product;
        }

        product = 1;
        for (int i = arr.Length - 2; i != -1; i--)
        {
            product *= arr[i + 1];
            products[i] *= product;
        }

        return products;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 1, 2], [4, 2, 4, 2]);
        Run([0, 1, 2, 3], [6, 0, 0, 0]);
        Run([3, 2, 1, 0], [0, 0, 0, 6]);
    }

    private static void Run(int[] arr, int[] expectedResult)
    {
        int[] result = Solution.ProductExceptSelf(arr);
        Utilities.PrintSolution(arr, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
