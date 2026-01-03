// Detonate the Maximum Bombs
// ==========================
//
// You are given a list of bombs, where each bomb has a specific location and a range of effects. The range of a bomb is
// defined as a circular area centered at the bomb's location, with a radius equal to the bomb's range. If a bomb is
// detonated, it will trigger all other bombs whose centers lie within its range. These triggered bombs will further
// detonate any bombs within their respective ranges, creating a chain reaction.
//
// The bombs are represented by a 0-indexed 2D integer array, `bombs`, where:
//
// - `bombs[i] = [x_i, y_i, r_i]`:
//     - `x_i` and `y_i` represent the X and Y coordinates of the bomb's location.
//     - `r_i` represents the radius of the bomb's range.
//
// You may choose to detonate one bomb initially. Your task is to determine the maximum number of bombs that can be
// detonated if you start with the optimal choice of the initial bomb.
//
// > Note: A bomb will be detonated even if its location lies exactly on the boundary of another bomb's detonation
// > radius.
//
// Constraints:
//
// - 1 ≤ `bombs.length` ≤ 100
// - `bombs[i].length` == 3
// - 1 ≤ x_i, y_i, r_i ≤ 1000

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P19_DetonateTheMaximumBombs;

public class Solution
{
    // Time complexity: O(n^n), Space complexity: O(n).
    public static int MaximumDetonation(int[][] bombs)
    {
        int maxDetonations = 0;

        for (int i = 0; i != bombs.Length; i++)
        {
            var detonated = new bool[bombs.Length];
            int detonations = 0;

            void Detonate(int i)
            {
                detonated[i] = true;
                detonations++;

                for (int j = 0; j != bombs.Length; j++)
                {
                    if (!detonated[j] && Math.Pow(bombs[i][0] - bombs[j][0], 2) + Math.Pow(bombs[i][1] - bombs[j][1], 2) <= Math.Pow(bombs[i][2], 2))
                    {
                        Detonate(j);

                    }
                }
            }

            Detonate(i);
            maxDetonations = Math.Max(maxDetonations, detonations);
        }

        return maxDetonations;
    }
}

internal static class Tests
{
    public static void Run()
    {
        // 4 _ _ _ 3
        // _ _ _ _ _
        // _ _ _ _ _
        // _ _ _ _ _
        // 1 _ _ _ 2
        Run([[1, 1, 1], [5, 1, 2], [5, 5, 3], [1, 5, 4]], 3);
        Run([[1, 1, 3], [1, 2, 1], [1, 3, 1], [1, 5, 2]], 4);
    }

    private static void Run(int[][] bombs, int expectedResult)
    {
        int[][] bombsCopy = bombs.ToArray();
        int result = Solution.MaximumDetonation(bombs);
        Utilities.PrintSolution(bombsCopy, result);
        Assert.AreEqual(expectedResult, result);
    }
}
