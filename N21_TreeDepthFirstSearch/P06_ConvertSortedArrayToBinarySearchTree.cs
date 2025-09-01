// Convert Sorted Array to Binary Search Tree
// ==========================================
//
// Given an array of integers, `nums`, sorted in ascending order, your task is to construct a height-balanced binary
// search tree (BST) from this array.
//
// In a height-balanced BST, the difference of heights of the left subtree and right subtree of any node is not more
// than 1.
//
// > Note: There can be multiple valid BSTs for a given input.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^4 ≤ `nums[i]` ≤ 10^4
// - `nums` is sorted in strictly ascending order.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P06_ConvertSortedArrayToBinarySearchTree;

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
