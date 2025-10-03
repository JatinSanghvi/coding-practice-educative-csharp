// Binary Watch
// ============
//
// A binary watch has 4 LEDs for displaying hours (ranging from 0 to 11) and 6 for displaying minutes (ranging from 0 to
// 59). Each LED can be on (1) or off (0), with the least significant bit on the right. For example, the binary watch
// below reads “9:22.”
//
// H 1 0 0 1
// M 0 1 0 1 1 0
//
// Given an integer `enabled`, which represents the number of LEDs currently turned on, return all possible times that
// the watch could display. You may return the answer in any order.
//
// > Note: Remember the following regarding leading zeros:
//
// > - The hour cannot have a leading zero (e.g., "01:00" is invalid, it should be "1:00").
// > - The minute must be two digits and may include a leading zero (e.g., "10:2" is invalid, it should be "10:02").
//
// Constraints:
//
// - 0 ≤ `enabled` ≤ 10

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P08_BinaryWatch;

public class Solution
{
    // Time complexity: O(10-choose-e), Space complexity: O(1).
    public static List<string> ReadBinaryWatch(int enabled)
    {
        int time = 0; // Bits 0..6 for minutes, 6..10 for hour.
        var times = new List<string>();
        Solve(0, enabled);
        return times;

        void Solve(int i, int enabled)
        {
            if (enabled == 0)
            {
                int hour = (time & 0x03C0) >> 6;
                int minute = time & 0x003F;
                if (hour < 12 && minute < 60)
                {
                    times.Add($"{hour}:{minute:d2}");
                }
                return;
            }

            for (; i != 11 - enabled; i++)
            {
                time |= (1 << i);
                Solve(i + 1, enabled - 1);
                time &= ~(1 << i);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(0, ["0:00"]);
        Run(1, ["0:01", "0:02", "0:04", "0:08", "0:16", "0:32", "1:00", "2:00", "4:00", "8:00"]);
        Run(10, []);
    }

    private static void Run(int enabled, string[] expectedResult)
    {
        string[] result = Solution.ReadBinaryWatch(enabled).ToArray();
        Utilities.PrintSolution(enabled, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
