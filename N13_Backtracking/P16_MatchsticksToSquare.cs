// Matchsticks to Square
// =====================
//
// Given an integer array, `matchsticks`, where `matchsticks[i]` is the length of the i-th matchstick. Use every single
// matchstick to create a square. No stick should be broken, although they can be connected, and each matchstick can
// only be used once.
//
// Return TRUE if we can make this square; otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `matchsticks.length` ≤ 15
// - 1 ≤ `matchsticks[i]` ≤ 10^3

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P16_MatchsticksToSquare;

public class Solution
{
    // Time complexity: O(4^n), Space complexity: O(1).
    public static bool MatchsticksToSquare(int[] matchsticks)
    {
        int perimeter = matchsticks.Sum();
        if (perimeter % 4 != 0) { return false; }

        int[] sides = Enumerable.Repeat(perimeter / 4, 4).ToArray();
        return Solve(0);

        bool Solve(int i)
        {
            if (i == matchsticks.Length) { return true; }

            for (int s = 0; s != 4; s++)
            {
                if (sides[s] >= matchsticks[i])
                {
                    sides[s] -= matchsticks[i];
                    bool solved = Solve(i + 1);
                    sides[s] += matchsticks[i];
                    if (solved) { return true; }
                }
            }

            return false;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 1, 1, 1, 4, 4, 4], true);
        Run([1, 1, 1, 1, 4, 4, 4, 4], true);
        Run([1, 1, 1, 1, 4, 4, 4, 4, 4], false);
    }

    private static void Run(int[] matchsticks, bool expectedResult)
    {
        bool result = Solution.MatchsticksToSquare(matchsticks);
        Utilities.PrintSolution(matchsticks, result);
        Assert.AreEqual(expectedResult, result);
    }
}
