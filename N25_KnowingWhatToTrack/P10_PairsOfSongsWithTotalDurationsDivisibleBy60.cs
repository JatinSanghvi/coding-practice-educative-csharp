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
