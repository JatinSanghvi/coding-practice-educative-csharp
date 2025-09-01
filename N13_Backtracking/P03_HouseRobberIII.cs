// House Robber III
// ================
//
// A thief has discovered a new neighborhood to target, where the houses can be represented as nodes in a binary tree.
// The money in the house is the data of the respective node. The thief can enter the neighborhood from a house
// represented as `root` of the binary tree. Each house has only one parent house. The thief knows that if he robs two
// houses that are directly connected, the police will be notified. The thief wants to know the maximum amount of money
// he can steal from the houses without getting caught by the police. The thief needs your help determining the maximum
// amount of money he can rob without alerting the police.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 500].
// - 0 ≤ `node.data` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P03_HouseRobberIII;

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
