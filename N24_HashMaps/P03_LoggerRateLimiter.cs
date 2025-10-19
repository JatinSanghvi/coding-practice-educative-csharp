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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P03_LoggerRateLimiter;

// Space complexity: O(n).
public class Solution(int timeLimit)
{
    private int limit = timeLimit;
    private Dictionary<string, int> times = new();

    // Time complexity: O(1).
    public bool MessageRequestDecision(int timestamp, string request)
    {
        if (times.TryGetValue(request, out int time) && timestamp - time < limit)
        {
            return false;
        }
        else
        {
            times[request] = timestamp;
            return true;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(5, [
            (0, "hello", true),
            (2, "bye", true),
            (4, "hello", false),
            (5, "hello", true),
            (6, "bye", false),
            (7, "bye", true),
        ]);
    }

    private static void Run(int timeLimit, (int, string, bool)[] requests)
    {
        var solution = new Solution(timeLimit);

        foreach ((int timestamp, string request, bool expectedResult) in requests)
        {
            bool result = solution.MessageRequestDecision(timestamp, request);
            Utilities.PrintSolution((timestamp, request), result);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
