// Pairs of Songs With Total Durations Divisible by 60
// ===================================================
//
// You are given a list of songs, where the duration of each song is represented by an integer array `time`, where
// `time[i]` indicates the length of the ith song in seconds.
//
// Your task is to find and return the number of pairs of songs `(i, j)` such that:
//
// - `i` < `j` (i.e., the pair should consist of two distinct songs)
// - The sum of their durations is divisible by 60, i.e., `(time[i] + time[j]) % 60 == 0`.
//
// Constraints:
//
// - 1 ≤ `time.length` ≤ 1000
// - 1 ≤ `time[i]` ≤ 500

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P10_PairsOfSongsWithTotalDurationsDivisibleBy60;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int NumPairsDivisibleBy60(int[] times)
    {
        var moduloCounts = new int[60];
        foreach (int time in times)
        {
            moduloCounts[time % 60]++;
        }

        int pairs = 0;
        for (int i = 1; i != 30; i++)
        {
            pairs += moduloCounts[i] * moduloCounts[60 - i];
        }

        pairs += moduloCounts[0] * (moduloCounts[0] - 1) / 2;
        pairs += moduloCounts[30] * (moduloCounts[30] - 1) / 2;

        return pairs;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 1, 30, 59, 60, 61, 90, 119], 6);
    }

    private static void Run(int[] times, int expectedResult)
    {
        int result = Solution.NumPairsDivisibleBy60(times);
        Utilities.PrintSolution(times, result);
        Assert.AreEqual(expectedResult, result);
    }
}
