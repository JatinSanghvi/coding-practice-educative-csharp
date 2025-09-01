// Logger Rate Limiter
// ===================
//
// For the given stream of message requests and their timestamps as input, you must implement a logger rate limiter
// system that decides whether the current message request is displayed. The decision depends on whether the same
// message has already been displayed in the last S seconds. If yes, then the decision is FALSE, as this message is
// considered a duplicate. Otherwise, the decision is TRUE.
//
// > Note: Several message requests, though received at different timestamps, may carry identical messages.
//
// Constraint:
//
// - 1 ≤ `request.length` ≤ 10^2
// - 0 ≤ `timestamp` ≤ 10^3
// - Timestamps are in ascending order.
// - Messages can be written in lowercase or uppercase English alphabets.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P03_LoggerRateLimiter;

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
