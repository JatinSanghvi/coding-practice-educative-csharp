// Kth Largest Element in a Stream
// ===============================
//
// Given an infinite stream of integers (sorted or unsorted), `nums`, design a class to find the kth largest element in
// a stream.
//
// > Note: It is the kth largest element in the sorted order, not the kth distinct element.
//
// The class should have the following functions, inputs, and return values:
//
// - Init(nums, k): It takes an array of integers `nums` and an integer `k` and initializes the class object.
// - Add(value): It takes one integer `value`, appends it to the stream, and returns the element representing the kth
//   largest element in the stream.
//
// Constraints:
//
// - 1 ≤ k ≤ 10^3
// - 0 ≤ `nums.length` ≤ 10^3
// - -10^3 ≤ `nums[i]` ≤ 10^3
// - -10^3 ≤ `value` ≤ 10^3
// - At most, 10^3 calls will be made to add.
// - It is guaranteed that there will be at least k elements in the array when you search for the kth element.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P01_KthLargestElementInAStream;

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
