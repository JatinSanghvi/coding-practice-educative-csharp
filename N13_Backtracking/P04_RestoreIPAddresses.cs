// Restore IP Addresses
// ====================
//
// A valid IP address consists of four numeric segments separated by single dots. Each segment must be an integer
// between 0 and 255 (inclusive), and leading zeros are not allowed unless the segment is exactly '0'.
//
// For instance, "10.0.1.25" and "172.16.0.5" are valid IP addresses, while "01.200.100.3," "256.100.50.25," and
// "172.16.0.500" are invalid.
//
// Given a string `s` made up of digits only, return all possible valid IP addresses that can be created by inserting
// exactly three dots into the string. You cannot rearrange or delete any digits. The resulting list of valid IP
// addresses can be returned in any order.
//
// Constraints:
//
// - The input string `s` consists of digits only.
// - 4 ≤ `s.length` ≤ 12

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P04_RestoreIPAddresses;

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
