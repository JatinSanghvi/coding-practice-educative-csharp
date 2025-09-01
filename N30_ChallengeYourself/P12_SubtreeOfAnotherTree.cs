// Subtree of Another Tree
// =======================
//
// Given the roots of two binary trees, `root` and `subRoot`, return TRUE if there is a subtree of `root` with the same
// structure and nodes as `subRoot`. Otherwise, return FALSE.
//
// A tree can only be considered a subtree of the `root` tree iff all the descendants (children) of the node appear in
// `subRoot`.
//
// Constraints:
//
// - The number of nodes in the `root` tree is in the range [1,500].
// - The number of nodes in the `subRoot` tree is in the range [1,250].
// - -10^4 ≤ [`root.data`](https://www.educative.io/courses/grokking-coding-interview-in-csharp/root.data) ≤ 10^4
// - -10^4 ≤ [`subRoot.data`](https://www.educative.io/courses/grokking-coding-interview-in-csharp/subRoot.data) ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P12_SubtreeOfAnotherTree;

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
