// Network Delay Time
// ==================
//
// A network of `n` nodes labeled 1 to n is provided along with a list of travel times for directed edges represented as
// `times[i] = (x_i, y_i, t_i)`, where `x_i` is the source node, `y_i` is the target node, and `t_i` is the delay time
// from the source node to the target node.
//
// Considering we have a starting node, `k`, we have to determine the minimum time required for all the remaining n - 1
// nodes to receive the signal. Return -1 if it's not possible for all n - 1 nodes to receive the signal.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `n` ≤ 100
// - 1 ≤ `times.length` ≤ 6000
// - `times[i].length` == 3
// - 1 ≤ x, y ≤ `n`
// - x != y
// - 0 ≤ t ≤ 100
// - Unique pairs of (x, y), which means that there should be no multiple edges

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P01_NetworkDelayTime;

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
