// Count the Number of Good Subsequences
// =====================================
//
// Count and return the number of good subsequences in the given string `s`. You may return the modulo 10^9 + 7 of the
// count.
//
// - A subsequence is a sequence formed from another sequence by deleting some or no elements while keeping the order of
//   the remaining elements unchanged.
//
// - A good subsequence is a subsequence of a string if it is not empty and the frequency of each character is the same.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^4
// - `s` will only contain lowercase English characters.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P15_CountTheNumberOfGoodSubsequences;

public class Solution
{
    private const int Mod = 1_000_000_007;
    private const int MaxLength = 10000;

    private static readonly long[] factorials = new long[MaxLength + 1];
    private static readonly long[] invFactorials = new long[MaxLength + 1];

    // Time complexity: O(max-len), Space complexity: O(max-len).
    static Solution()
    {
        factorials[0] = 1;
        for (long i = 1; i != factorials.Length; i++)
        {
            factorials[i] = (i * factorials[i - 1]) % Mod;
        }

        invFactorials[^1] = ModularReciprocal(factorials[^1]);
        for (long i = invFactorials.Length - 2; i != -1; i--)
        {
            invFactorials[i] = ((i + 1) * invFactorials[i + 1]) % Mod;
        }
    }

    public static long ModularReciprocal(long num)
    {
        long result = 1;
        long multiplier = num;

        // Fermats little theorem: a^(p-1) % p == 1 if p is prime. Therefore, a^(p-2) % p = a^(-1).
        for (int power = Mod - 2; power != 0; power /= 2)
        {
            // Computing modular exponentiation by squaring technique.
            if (power % 2 != 0)
            {
                result = (result * multiplier) % Mod;
            }

            multiplier = (multiplier * multiplier) % Mod;
        }

        return result;
    }

    public static long Combinations(int n, int k)
    {
        return n < k ? 0 : (((factorials[n] * invFactorials[k]) % Mod) * invFactorials[n - k]) % Mod;
    }

    // Time complexity: O(n), Space complexity: O(max-length).
    public static int CountGoodSubsequences(string s)
    {
        var charCounts = new int[26];

        foreach (char ch in s)
        {
            charCounts[ch - 'a']++;
        }

        int maxCount = 0;
        foreach (int count in charCounts)
        {
            maxCount = Math.Max(maxCount, count);
        }

        long allSequences = 0;
        for (int length = 1; length != maxCount + 1; length++)
        {
            long sequences = 1; // There is an empty sequence for each length.
            foreach (int count in charCounts)
            {
                // Adding 1 ensures that we also consider sequences with no occurence of the character.
                sequences = (sequences * (Combinations(count, length) + 1) % Mod) % Mod;
            }

            allSequences = (allSequences + sequences - 1) % Mod; // Remove empty sequence.
        }

        return (int)allSequences;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("aabb", 11);
        Run("abbccc", 31);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.CountGoodSubsequences(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
