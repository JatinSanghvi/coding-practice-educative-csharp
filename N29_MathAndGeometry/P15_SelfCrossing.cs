// Self Crossing
// =============
//
// You are given an array of integers, `distance`, where each element represents the length of a move you will make on
// an X-Y plane. You start at the origin, which is point (0,0), and move according to the array. Specifically, you move
// `distance[0]` meters north, `distance[1]` meters west, `distance[2]` meters south, `distance[3]` meters east, and
// continue this pattern in a counterclockwise direction. Each step follows the sequence---north, west, south,
// east---repeating as long as there are remaining distances in the array.
//
// Your task is to determine whether this path crosses itself at any point. This means checking whether you revisit any
// previously visited position (including the origin or any other point) at any step. Return TRUE if the path intersects
// itself, and FALSE otherwise.
//
// Constraints:
//
// - 1 ≤ `distance.length` ≤ 10^3
// - 1 ≤ `distance[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P15_SelfCrossing;

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
