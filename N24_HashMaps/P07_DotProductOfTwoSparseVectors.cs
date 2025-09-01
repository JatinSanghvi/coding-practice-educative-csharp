// Dot Product of Two Sparse Vectors
// =================================
//
// We must calculate the dot product of two given sparse vectors, `nums1` and `nums2`.
//
// Create a SparseVector class:
//
// - Constructor(): Initializes the object with the vector.
// - DotProduct(): Computes the dot product between the current instance of the vector and the other.
//
// > Note: A sparse vector is a vector that contains mostly zero values. Therefore, we should store the sparse vectors
// > and calculate the dot product accordingly.
//
// Constraints:
//
// - n = `nums1.length` = `nums2.length`
// - 1 ≤ n ≤ 10^3
// - 0 ≤ `nums1[i]`, `nums2[i]` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P07_DotProductOfTwoSparseVectors;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
