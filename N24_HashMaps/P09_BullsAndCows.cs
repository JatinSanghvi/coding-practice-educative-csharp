// Bulls and Cows
// ==============
//
// You are playing a number guessing game called "Bulls and Cows" with a friend.
//
// You write down a `secret` number, and your friend tries to `guess` it. After each `guess`, you provide a hint based
// on the following:
//
// - Bulls: The number of digits that are in the correct position in the `guess`.
// - Cows: The number of digits that are in both the `secret` and the `guess` but in different positions. (These are
//   non-bull digits that could become bulls if rearranged.)
//
// Your task is to return a hint for the `guess`, formatted as "xAyB", where:
//
// - x is the number of bulls.
// - y is the number of cows.
//
// > Note: Both the `secret` number and the `guess` may contain duplicate digits.
//
// Constraints:
//
// - 1 <= `secret.length`, `guess.length` ≤ 10^3
// - `secret.length` == `guess.length`
// - `secret` and `guess` consist of digits only.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P09_BullsAndCows;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static string GetHint(string secret, string guess)
    {
        var counts1 = new int[10];
        var counts2 = new int[10];

        int bulls = 0;
        for (int i = 0; i != secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
            }
            else
            {
                counts1[secret[i] - '0']++;
                counts2[guess[i] - '0']++;
            }
        }

        int cows = 0;
        for (int i = 0; i != 10; i++)
        {
            cows += Math.Min(counts1[i], counts2[i]);
        }

        return $"{bulls}A{cows}B";
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("00112233", "01230123", "2A6B");
        Run("00112233", "01234567", "1A3B");
    }

    private static void Run(string secret, string guess, string expectedResult)
    {
        string result = Solution.GetHint(secret, guess);
        Utilities.PrintSolution((secret, guess), result);
        Assert.AreEqual(expectedResult, result);
    }
}
