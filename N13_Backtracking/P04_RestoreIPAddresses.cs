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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P04_RestoreIPAddresses;

public class Solution
{
    // Time complexity: O(3^4) or O(1), Space complexity: O(1).
    public static List<string> RestoreIpAddresses(string str)
    {
        var addresses = new List<string>();
        var starts = new int[5];
        Solve(0);
        return addresses;

        void Solve(int seg)
        {
            if (seg == 4)
            {
                if (starts[seg] == str.Length)
                {
                    addresses.Add(string.Join(
                        ".",
                        str[starts[0]..starts[1]],
                        str[starts[1]..starts[2]],
                        str[starts[2]..starts[3]],
                        str[starts[3]..starts[4]]));
                }

                return;
            }

            for (int len = 1; len != 4 && starts[seg] + len != str.Length + 1; len++)
            {
                starts[seg + 1] = starts[seg] + len;
                int num = int.Parse(str[starts[seg]..starts[seg + 1]]);
                if (num <= 255 && (len == 1 || str[starts[seg]] != '0'))
                {
                    Solve(seg + 1);
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("123123123", [
            "1.23.123.123", "1.231.23.123", "1.231.231.23",
            "12.3.123.123", "12.31.23.123", "12.31.231.23",
            "123.1.23.123", "123.1.231.23", "123.12.3.123",
            "123.12.31.23", "123.123.1.23", "123.123.12.3"]);

        Run("010010", ["0.10.0.10", "0.100.1.0"]);
    }

    private static void Run(string str, string[] expectedResult)
    {
        string[] result = Solution.RestoreIpAddresses(str).ToArray();
        Utilities.PrintSolution(str, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
