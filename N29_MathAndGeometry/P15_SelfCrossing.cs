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
    // Time complexity: O(n), Space complexity: O(1).
    public bool IsSelfCrossing(int[] distance)
    {
        // Any line should intersect with a line earlier in order by 3, 4, or 5 before intersecting any other line.
        for (int i = 0; i != distance.Length; i++)
        {
            if (
                (i >= 3 && distance[i] >= distance[i - 2] && distance[i - 3] >= distance[i - 1]) ||
                (i >= 4 && distance[i] + distance[i - 4] >= distance[i - 2] && distance[i - 1] == distance[i - 3]) ||
                (i >= 5 && distance[i] >= distance[i - 2] - distance[i - 4] && distance[i - 2] > distance[i - 4] && distance[i - 1] <= distance[i - 3] && distance[i - 1] + distance[i - 5] >= distance[i - 3]))
            {
                return true;
            }
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 2, 2, 1], false);
        Run([2, 2, 2, 2], true);
        Run([2, 1, 1, 2], true);
        Run([1, 1, 3, 1, 1], false);
        Run([1, 1, 3, 1, 2], true);
        Run([1, 1, 3, 1, 5], true);
        Run([1, 1, 2, 3, 1, 1], false);
        Run([1, 1, 2, 3, 1, 2], true);
        Run([2, 2, 3, 3, 2, 2], true);
    }

    private static void Run(int[] distance, bool expectedResult)
    {
        bool result = new Solution().IsSelfCrossing(distance);
        Utilities.PrintSolution(distance, result);
        Assert.AreEqual(expectedResult, result);
    }
}
