// Given a string `s`, return the minimum number of moves required to transform `s` into a palindrome. In each move, you
// can swap any two adjacent characters in `s`.
//
// > Note: The input string is guaranteed to be convertible into a palindrome.
// 
// Constraints:
// - 1 ≤ `s.length` ≤ 2000
// - `s` consists of only lowercase English letters.
// - `s` is guaranteed to be converted into a palindrome in a finite number of moves.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P08_MinimumNumberOfMovesToMakePalindrome;

public class Solution
{
    public int MinMovesToMakePalindrome(string s)
    {
        char[] chars = s.ToCharArray();
        int moves = 0;
        int left = 0, right = s.Length - 1, middle = s.Length / 2;

        while (left < right)
        {
            int match;
            for (match = left; chars[match] != chars[right]; match++) ;

            if (match == right)
            {
                middle = right;
                right -= 1;
            }
            else
            {
                char temp = chars[match];
                for (int target = match; target > left; target--)
                {
                    chars[target] = chars[target - 1];
                }
                chars[left] = temp;

                moves += match - left;
                left += 1;
                right -= 1;
            }
        }

        return moves + middle - s.Length / 2;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Assert.AreEqual(16, new Solution().MinMovesToMakePalindrome("mmmaaabbbba"));
    }
}
