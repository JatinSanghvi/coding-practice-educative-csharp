// Longest Path With Different Adjacent Characters
// ===============================================
//
// You are given a rooted tree with `n` nodes, numbered from `0` to `n - 1`, where the tree is connected, undirected,
// and has no cycles. The tree is represented by a 0-indexed array `parent` of size `n`, where `parent[i]` is the parent
// of node `i`. The root node is node `0`, so `parent[0] = -1`.
//
// Additionally, you are provided a string `s` of length `n`, where `s[i]` represents the character assigned to node
// `i`.
//
// Your task is to find the length of the longest path in the tree where no two consecutive nodes on the path share the
// same character. Return the length of this path.
//
// Constraints:
//
// - n == `parent.length` == `s.length`
// - 1 ≤ n ≤ 10^5
// - 0 ≤ `parent[i]` ≤ n - 1 for all `i` ≥ 1
// - `parent[0]` = -1
// - `parent` represents a valid tree.
// - `s` consists of only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P07_LongestPathWithDifferentAdjacentCharacters;

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
