// Exclusive Time of Functions
// ===========================
//
// We are given an integer number, `n`, representing the number of functions running in a single-threaded CPU, and an
// execution log, which is essentially a list of strings. Each string has the format `{function id}:{"start" |
// "end"}:{timestamp}`, indicating that the function with `function id` either started or stopped execution at the time
// identified by the `timestamp` value. Each function has a unique ID between 0 and n - 1. Compute the exclusive time of
// the functions in the program.
//
// > Note: The exclusive time is the sum of the execution times for all the calls to a specific function.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 100
// - 1 ≤ `logs.length` ≤ 500
// - 0 ≤ `function id` < `n`
// - 0 ≤ `timestamp` ≤ 10^3
// - No two start events and two end events will happen at the same `timestamp`.
// - Each function has an `end` log entry for each `start` log entry.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P04_ExclusiveTimeOfFunctions;

public class Solution
{
    // Time complexity: O(e), Space complexity: O(e).
    public static List<int> ExclusiveTime(int n, List<string> events)
    {
        var durations = new int[n];
        var ids = new Stack<int>();
        int startTime = 0;

        foreach (string event_ in events)
        {
            string[] tokens = event_.Split(':');

            int id = int.Parse(tokens[0]);
            bool start = tokens[1] == "start";
            int time = int.Parse(tokens[2]);

            if (start)
            {
                if (ids.Count != 0)
                {
                    durations[ids.Peek()] += time - startTime;
                }

                ids.Push(id);
                startTime = time;
            }
            else
            {
                int duration = time - startTime + 1;
                durations[id] += duration;
                ids.Pop();
                startTime = time + 1;
            }
        }

        return durations.ToList();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(3, ["0:start:0", "1:start:2", "1:end:4", "2:start:6", "2:end:8", "1:start:10", "1:end:12", "0:end:14"], [6, 6, 3]);
    }

    private static void Run(int n, string[] events, int[] expectedResult)
    {
        int[] result = Solution.ExclusiveTime(n, events.ToList()).ToArray();
        Utilities.PrintSolution((n, events), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
