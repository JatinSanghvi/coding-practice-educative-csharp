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
// - 2 ≤ `asteroids.length` ≤ 10^3
// - -10^3 ≤ `asteroids[i]` ≤ 10^3
// - `asteroids[i]` ≠ 0

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P36_AsteroidCollision;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int[] asteroidCollision(int[] asteroids)
    {
        var survivors = new Stack<int>();
        foreach (int asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                survivors.Push(asteroid);
            }
            else
            {
                while (survivors.Count != 0 && survivors.Peek() > 0 && survivors.Peek() < -asteroid)
                {
                    survivors.Pop(); // Remove smaller asteroids in right direction.
                }

                if (survivors.Count == 0 || survivors.Peek() < 0)
                {
                    survivors.Push(asteroid); // Keep asteroid in left direction if it could move all the way.
                }
                else if (survivors.Count != 0 && survivors.Peek() == -asteroid)
                {
                    survivors.Pop(); // Remove equal asteroid in right direction.
                }
            }
        }

        return survivors.Reverse().ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, -1, -1, -2, 2, 5, 3, -4, 1], [-1, -2, 2, 5, 1]);
    }

    private static void Run(int[] asteroids, int[] expectedResult)
    {
        int[] result = Solution.asteroidCollision(asteroids);
        Utilities.PrintSolution(asteroids, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
