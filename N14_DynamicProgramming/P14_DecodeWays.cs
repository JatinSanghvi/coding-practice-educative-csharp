// Decode Ways
// ===========
//
// Given a string that has only positive digits, your task is to decode the string and determine the number of possible
// ways to decode it.
//
// Consider the input string as an encoded message, where each digit in the string represents an alphabet from A to Z.
// For reference, let's look at the mapping below:
//
// `"1"` represents `"A"`
// `"2"` represents `"B"`
// `"3"` represents `"C"`
// ......
// `"26"` represents `"Z"`
//
// How to perform the decode operation?
//
// To decode an encoded message, we have to check whether or not each digit in the string can be mapped onto the mapping
// above. There can be multiple ways to decode a string.
//
// For example, the string `"231012"` can be decoded in the following ways:
//
// - Option 1 → `"2", "3", "10", "1", "2"` → `"B", "C", "J", "A", "B"`
// - Option 2 → `"2", "3", "10", "12"` → `"B", "C", "J", "L"`
// - Option 3 → `"23", "10", "1", "2"` → `"W", "J", "A", "B"`
// - Option 4 → `"23", "10", "12"` → `"W", "J", "L"`
//
// > Note: In the mapping above, we haven't included `"01"` since it's an invalid mapping. It cannot be mapped onto
// > `"A"` since `"01"` and `"1"` are different.
//
// Constraints:
//
// - 1 ≤ `decodeStr.length` ≤ 100
// - The string `decodeStr` contains only digits and may contain leading zero(s).

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P14_DecodeWays;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int NumOfDecodings(string decodeStr)
    {
        int prevCount = 0, count = 1;

        for (int end = 0; end != decodeStr.Length; end++)
        {
            bool canDecode2 = end != 0 && (decodeStr[end - 1] == '1' || (decodeStr[end - 1] == '2' && decodeStr[end] <= '6'));
            bool canDecode1 = decodeStr[end] != '0';

            (prevCount, count) = (count, (canDecode2 ? prevCount : 0) + (canDecode1 ? count : 0));
        }

        return count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("0", 0);
        Run("1", 1);
        Run("101", 1);
        Run("1001", 0);
        Run("123456789", 3);
    }

    private static void Run(string decodeStr, int expectedResult)
    {
        int result = Solution.NumOfDecodings(decodeStr);
        Utilities.PrintSolution(decodeStr, result);
        Assert.AreEqual(expectedResult, result);
    }
}
