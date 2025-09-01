// Binary Tree Cameras
// ===================
//
// You are given the `root` of a binary tree. Cameras can be installed on any node, and each camera can monitor itself,
// its parent, and its immediate children.
//
// Your task is to determine the minimum number of cameras required to monitor every node in the tree.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 1000].
// - `Node.data` == 0

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P16_BinaryTreeCameras;

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
