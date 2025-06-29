// Valid Palindrome II
// ===================
// 
// Write a function that takes a string as input and checks whether it can be a valid palindrome by removing at most one
// character from it.
// 
// Constraints:
// 
// - 1 ≤ `string.length` ≤ 10^5
// - The string only consists of English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P13_ValidPalindromeII;

public class Solution
{
    public static bool IsPalindrome(string str)
    {
        int left, right, left2, right2;

        for (left = 0, right = str.Length - 1; left < right && str[left] == str[right]; left++, right--) ;
        if (left >= right) { return true; }

        for (left2 = left, right2 = right - 1; left2 < right2 && str[left2] == str[right2]; left2++, right2--) ;
        if (left2 >= right2) { return true; }

        for (left2 = left + 1, right2 = right; left2 < right2 && str[left2] == str[right2]; left2++, right2--) ;
        if (left2 >= right2) { return true; }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("a", true);
        Run("abccbcca", true);
        Run("abcccbcca", false);
    }

    private static void Run(string str, bool expectedResult)
    {
        bool result = Solution.IsPalindrome(str);
        Utilities.PrintSolution(str, result);
        Assert.AreEqual(expectedResult, result);
    }
}
