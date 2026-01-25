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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P07_DotProductOfTwoSparseVectors;

// Space complexity: O(k) where k = non-zero elements in nums.
public class SparseVector
{
    public Dictionary<int, int> Nums = new();

    // Time complexity: O(n).
    public SparseVector(int[] nums)
    {
        for (int i = 0; i != nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                Nums[i] = nums[i];
            }
        }
    }

    // Time complexity: O(k).
    public int DotProduct(SparseVector vec)
    {
        int product = 0;
        foreach ((int i, int num1) in Nums)
        {
            product += num1 * (vec.Nums.TryGetValue(i, out int num2) ? num2 : 0);
        }

        return product;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 0, 2, 0], [0, 0, 3, 4], 6);
    }

    private static void Run(int[] nums1, int[] nums2, int expectedResult)
    {
        int result = new SparseVector(nums1).DotProduct(new SparseVector(nums2));
        Utilities.PrintSolution((nums1, nums2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
