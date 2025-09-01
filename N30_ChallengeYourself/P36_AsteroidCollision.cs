// Asteroid Collision
// ==================
//
// We are provided an array of integers, `asteroids`, representing asteroids in a row. The absolute integer value of
// each asteroid represents its size, and the sign represents its direction. A positive sign signifies that the asteroid
// is moving toward the right direction, while a negative sign indicates it is moving toward the left. All asteroids
// move at the same speed.
//
// We need to determine the final state of the `asteroids` after all the collisions have occurred. When two asteroids of
// different sizes collide, the smaller one will be destroyed. If both asteroids are of the same size, both will be
// destroyed.
//
// > Note: Asteroids moving in the same direction will never collide.
//
// Constraints:
//
// - 2≤ `asteroids.length` ≤103
//
// - -103≤ `asteroids[i]` ≤103
//
// - `asteroids[i]` ≠0

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P36_AsteroidCollision;

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
