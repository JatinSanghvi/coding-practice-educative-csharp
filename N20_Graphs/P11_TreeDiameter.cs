// Tree Diameter
// =============
//
// Given an undirected tree with n nodes labeled from 0 to n - 1, represented by a 2D array `edges` where `edges.length
// == n - 1`. Each `edges[i] = [a_i, b_i]` denotes an undirected edge between nodes `a_i` and `b_i`. Your task is to
// return the diameter of the tree.
//
// > The diameter of a tree is the number of edges in the longest path between any two nodes.
//
// Constraints:
//
// - n == `edges.length` + 1
// - `edges[i].length` = 2
// - 1 ≤ n ≤ 10^3
// - 0 ≤ a_i, b_i < n
// - a_i ≠ b_i

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P11_TreeDiameter;

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
