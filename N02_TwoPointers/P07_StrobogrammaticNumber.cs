// Strobogrammatic Number
// ======================
//
// Given a string `num` representing an integer, determine whether it is a strobogrammatic number. Return TRUE if the
// number is strobogrammatic or FALSE if it is not.
//
// > Note: A strobogrammatic number appears the same when pairs 180 degrees (viewed upside down). For example, "69" is
// strobogrammatic because it looks the same when flipped upside down, while "962" is not.
//
// Constraints:
//
// - 1 <= `num.length` <= 50
// - `num` contains only digits.
// - `num` has no leading zeros except when the number itself is zero.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P07_StrobogrammaticNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static bool IsStrobogrammatic(string num)
    {
        var rotated = new Dictionary<char, char> { ['0'] = '0', ['1'] = '1', ['6'] = '9', ['8'] = '8', ['9'] = '6' };

        for (int left = 0, right = num.Length - 1; left <= right; left++, right--)
        {
            if (!rotated.TryGetValue(num[left], out char rotatedLeft) || rotatedLeft != num[right])
            {
                return false;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("1068968901", true);
        Run("2", false);
    }

    private static void Run(string num, bool expectedResult)
    {
        bool result = Solution.IsStrobogrammatic(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
